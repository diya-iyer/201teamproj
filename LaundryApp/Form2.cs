using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaundryMachines;
using Newtonsoft.Json; //for json additions



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

            //populate the DataGridView w/ laundry history
            PopulateHistoryGrid();

            //attach event handlers
            searchButton.Click += SearchButton_Click;
            viewReportButton.Click += ViewReportButton_Click;

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
                if (entry is { Type: "Washer", Load: WashLoad washLoad })
                {
                    historyDataGridView.Rows.Add("Washer", washLoad.machineName, washLoad.selectedWashType, washLoad.selectedTemperature, washLoad.loadName, washLoad.loadInterval);
                }
                else if (entry is { Type: "Dryer", Load: DryLoad dryLoad })
                {
                    historyDataGridView.Rows.Add("Dryer", dryLoad.machineName, dryLoad.selectedDryType, string.Empty, dryLoad.loadName, dryLoad.loadInterval);
                }
            }

        }

        //i'm thinking that instead reports should accept a list from the history log that should be used, as navigating to reports from this page seems redundant
        private void ViewReportButton_Click(object sender, EventArgs e)
        {
            //navigate to report page
            Report reportForm = new Report(washHistory, dryHistory);
            reportForm.Show();
        }

    }


}
