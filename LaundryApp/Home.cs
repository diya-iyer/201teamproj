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
using Newtonsoft.Json;
using System.IO;

namespace LaundryApp
{
    public partial class Home : Form
    {
        // Author: Christine Espeleta
        // Purpose: The Home page will display up to 4 current loads (2 for washing, 2 for drying). It also has an option to help the user register a new load by selecting a laundromat from the dropdown menu.

        public Home(List<WashLoad> currentWashLoads, List<DryLoad> currentDryLoads)
        {
            InitializeComponent();

            // nav bar buttons - navigate to other forms
            this.availabilityToolStripButton.Click += new EventHandler(this.AvailabilityToolStripButton__Click);
            this.historyToolStripButton.Click += new EventHandler(this.HistoryToolStripButton__Click);
            this.reportToolStripButton.Click += new EventHandler(this.ReportToolStripButton__Click);

            // clicking go button
            this.goButton.Click += new EventHandler(this.GoButton__Click);

            // initially hide current load groupboxes, only show and enable them depending on the number of current loads
            this.currentLoadsWasherGroupBox1.Enabled = false;
            this.currentLoadsWasherGroupBox1.Visible = false;
            this.currentLoadsWasherGroupBox2.Enabled = false;
            this.currentLoadsWasherGroupBox2.Visible = false;
            this.currentLoadsDryerGroupBox1.Enabled = false;
            this.currentLoadsDryerGroupBox1.Visible = false;
            this.currentLoadsDryerGroupBox2.Enabled = false;
            this.currentLoadsDryerGroupBox2.Visible = false;

            // if there are washer loads
            if (currentWashLoads.Count > 0)
            {
                // change groupbox visibility
                this.currentLoadsWasherGroupBox1.Enabled = true;
                this.currentLoadsWasherGroupBox1.Visible = true;
                // add washer load info
                this.groupBox1LaundromatLabel.Text = currentWashLoads[0].location;
                this.groupBox1MachineLabel.Text = currentWashLoads[0].machineName;
                this.groupBox1TimeLabel.Text = "Finishing at " + DateTime.Now.AddMinutes(Convert.ToDouble(currentWashLoads[0].loadInterval)).ToString("H:mm");

                if (currentWashLoads.Count > 1)
                {
                    // change groupbox visibility
                    this.currentLoadsWasherGroupBox2.Enabled = true;
                    this.currentLoadsWasherGroupBox2.Visible = true;
                    // add washer load info
                    this.groupBox2LaundromatLabel.Text = currentWashLoads[1].location;
                    this.groupBox2MachineLabel.Text = currentWashLoads[1].machineName;
                    this.groupBox2TimeLabel.Text = "Finishing at " + DateTime.Now.AddMinutes(Convert.ToDouble(currentWashLoads[1].loadInterval)).ToString("H:mm");
                }
            }

            // if there are dryer loads
            if (currentDryLoads.Count > 0)
            {
                // change groupbox visibility
                this.currentLoadsDryerGroupBox1.Enabled = true;
                this.currentLoadsDryerGroupBox1.Visible = true;
                // add dryer load info
                this.groupBox3LaundromatLabel.Text = currentDryLoads[0].location;
                this.groupBox3MachineLabel.Text = currentDryLoads[0].machineName;
                this.groupBox3TimeLabel.Text = "Finishing at " + DateTime.Now.AddMinutes(Convert.ToDouble(currentDryLoads[0].loadInterval)).ToString("H:mm");
                if (currentDryLoads.Count > 1)
                {
                    // change groupbox visibility
                    this.currentLoadsDryerGroupBox2.Enabled = true;
                    this.currentLoadsDryerGroupBox2.Visible = true;
                    // add dryer load info
                    this.groupBox4LaundromatLabel.Text = currentDryLoads[1].location;
                    this.groupBox4MachineLabel.Text = currentDryLoads[1].machineName;
                    this.groupBox4TimeLabel.Text = "Finishing at " + DateTime.Now.AddMinutes(Convert.ToDouble(currentDryLoads[1].loadInterval)).ToString("H:mm");
                }
            }
        }

        private void AvailabilityToolStripButton__Click(object sender, EventArgs e)
        {
            AvailabilityForm availabilityForm = new AvailabilityForm();
            availabilityForm.ShowDialog();
        }

        private void HistoryToolStripButton__Click(object sender, EventArgs e)
        {
           //history historyform = new history();
           //historyform.showdialog();
        }

        private void ReportToolStripButton__Click(object sender, EventArgs e)
        {
            // code for open report form once that goes up
        }

        // click on the go button
        private void GoButton__Click(object sender, EventArgs e)
        {
            // check to see if there is an input for laundromat
            // if there isn't, show an error
            if(this.laundromatComboBox.SelectedItem != null) {
                this.errorProvider.SetError(laundromatComboBox, "");
                MachineInfo machineInfo = new MachineInfo(this.laundromatComboBox.SelectedItem.ToString());
                machineInfo.ShowDialog();
            }
            else
            {
                this.errorProvider.SetError(laundromatComboBox, "Please select a laundromat.");
            }
        }
    }
}