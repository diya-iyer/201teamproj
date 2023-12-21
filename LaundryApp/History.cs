using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaundryMachines; //team project library
using Newtonsoft.Json; //for json additions
using System.IO;



/*
 * Tyler Aluko
 * IGME.201 - Team 2 Project
 * The History module allows users to see their past laundry events and save their settings.
 * Redirects to the Report module.
 */
namespace LaundryApp
{
    
   
    public partial class History : Form
    {

        //machine info lists
        private List<WashLoad> washHistory;
        private List<DryLoad> dryHistory;

        //lists as parameter
        public History(List<WashLoad> washHistory, List<DryLoad> dryHistory)
        {
            
            InitializeComponent();
            
            this.washHistory = washHistory;
            this.dryHistory = dryHistory;

            //populate DataGridView w/ laundry history
            PopulateHistoryGrid();

            //attach event handlers
            searchButton.Click += SearchButton_Click;

        }

        private void PopulateHistoryGrid()
        {

            historyDataGridView.Rows.Clear();

            foreach (WashLoad washLoad in washHistory)
            {
                historyDataGridView.Rows.Add("Washer", washLoad.machineName, washLoad.selectedWashType, washLoad.selectedTemperature, washLoad.loadName, washLoad.loadInterval);
            }

            foreach (DryLoad dryLoad in dryHistory)
            {
                historyDataGridView.Rows.Add("Dryer", dryLoad.machineName, dryLoad.selectedDryType, string.Empty, dryLoad.loadName, dryLoad.loadInterval);
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            string searchText = searchTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            { //if search box empty
                //show all history if search text empty
                PopulateHistoryGrid();
            }
            else
            {
                //filter history based on search text
                List<object> filteredHistory = new List<object>();

                foreach (WashLoad washLoad in washHistory)
                {
                    if (washLoad.machineName.ToLower().Contains(searchText) ||
                        washLoad.selectedWashType.ToLower().Contains(searchText) ||
                        washLoad.selectedTemperature.ToLower().Contains(searchText) ||
                        washLoad.loadName.ToLower().Contains(searchText) ||
                        washLoad.loadInterval.ToString().Contains(searchText))
                    {
                        filteredHistory.Add(new { Type = "Washer", Load = washLoad });
                    }
                }

                foreach (DryLoad dryLoad in dryHistory)
                {
                    if (dryLoad.machineName.ToLower().Contains(searchText) ||
                        dryLoad.selectedDryType.ToLower().Contains(searchText) ||
                        dryLoad.loadName.ToLower().Contains(searchText) ||
                        dryLoad.loadInterval.ToString().Contains(searchText))
                    {
                        filteredHistory.Add(new { Type = "Dryer", Load = dryLoad });
                    }
                }

                //update DataGridView w/ filtered results
                UpdateHistoryGrid(filteredHistory);

            }

        }

        private void UpdateHistoryGrid(List<object> filteredHistory)
        {
            
            historyDataGridView.Rows.Clear();

            foreach (object entry in filteredHistory)
            {
                if (entry is WashLoad washLoad && ((string)entry.GetType().GetProperty("Type").GetValue(entry)) == "washer")
                {
                    historyDataGridView.Rows.Add("Washer", washLoad.machineName, washLoad.selectedWashType, washLoad.selectedTemperature, washLoad.loadName, washLoad.loadInterval);
                }
                else if (entry is DryLoad dryLoad && ((string)entry.GetType().GetProperty("Type").GetValue(entry)) == "dryer")
                {
                    historyDataGridView.Rows.Add("Dryer", dryLoad.machineName, dryLoad.selectedDryType, string.Empty, dryLoad.loadName, dryLoad.loadInterval);
                }
            }

        }

        //i'm thinking that reports should instead accept a list from history to be used, as navigating to reports from this page seems redundant

    }

    
}
