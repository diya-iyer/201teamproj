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

        //for home navigation - defined properties for selectedWasherList/DryerList
        public List<WashLoad> SelectedWasherList { get; private set; } = new List<WashLoad>();
        public List<DryLoad> SelectedDryerList { get; private set; } = new List<DryLoad>();

        //for home navigation - defined event to notify when navigation to Home requested
        public event EventHandler NavigationToHomeRequested;

        //lists as parameter
        public History(List<WashLoad> washHistory, List<DryLoad> dryHistory)
        {
            
            InitializeComponent();
            
            this.washHistory = washHistory;
            this.dryHistory = dryHistory;

            //populate DataGridView w/ laundry history
            PopulateHistoryGrid();


            //attach event handlers
            searchButton.Click += new EventHandler(SearchButton_Click);
            this.homeToolStripButton.Click += new EventHandler(HomeToolStripButton_Click);
            this.availToolStripButton.Click += new EventHandler(AvailToolStripButton_Click);
            this.reportToolStripButton.Click += new EventHandler(ReportToolStripButton_Click);

        }

        //home navigation
        private void HomeToolStripButton_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Home homeForm = new Home(selectedWasherList, selectedDryerList);
            homeForm.ShowDialog();*/

            //set properties w/ current selected lists
            SelectedWasherList = washHistory;
            SelectedDryerList = dryHistory;

            //notify navigation to Home request (whatever this means)
            NavigationToHomeRequested?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        //availability navigation
        private void AvailToolStripButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvailabilityForm availForm = new AvailabilityForm();
            availForm.ShowDialog();
        }

        //report navigation
        private void ReportToolStripButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ReportPage reportForm = new LaundryApp.ReportForm();
            //reportForm.ShowDialog;
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

        //this thing sucks
        private void UpdateHistoryGrid(List<object> filteredHistory)
        {

            historyDataGridView.Rows.Clear();

            try
            {
                foreach (object entry in filteredHistory)
                {
                    string type = (string)entry.GetType().GetProperty("Type").GetValue(entry);

                    if (entry is WashLoad washLoad && type == "Washer")
                    {
                        historyDataGridView.Rows.Add("Washer", washLoad.machineName, washLoad.selectedWashType, washLoad.selectedTemperature, washLoad.loadName, washLoad.loadInterval);
                    }
                    else if (entry is DryLoad dryLoad && type == "Dryer")
                    {
                        historyDataGridView.Rows.Add("Dryer", dryLoad.machineName, dryLoad.selectedDryType, string.Empty, dryLoad.loadName, dryLoad.loadInterval);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }


}
