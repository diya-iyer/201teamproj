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
        public Home()
        {
            InitializeComponent();
            // grab info from machine info page
            MachineInfo machineInfo = new MachineInfo(this.laundromatComboBox.SelectedItem.ToString());

            // nav bar buttons - navigate to other forms
            this.homeToolStripButton.Click += new EventHandler(this.HomeToolStripButtonButton__Click);
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
            if (machineInfo.washers.Count > 0)
            {
                // change groupbox visibility
                this.currentLoadsWasherGroupBox1.Enabled = true;
                this.currentLoadsWasherGroupBox1.Visible = true;
                // add washer load info
                this.groupBox1LaundromatLabel.Text = machineInfo.washers[0].location;
                this.groupBox1MachineLabel.Text = machineInfo.washers[0].machineName;
                this.groupBox1TimeLabel.Text = machineInfo.washers[0].loadInterval.ToString();

                if (machineInfo.washers.Count > 1)
                {
                    // change groupbox visibility
                    this.currentLoadsWasherGroupBox2.Enabled = true;
                    this.currentLoadsWasherGroupBox2.Visible = true;
                    // add washer load info
                    this.groupBox2LaundromatLabel.Text = machineInfo.washers[1].location;
                    this.groupBox2MachineLabel.Text = machineInfo.washers[1].machineName;
                    this.groupBox2TimeLabel.Text = machineInfo.washers[1].loadInterval.ToString();
                }
            }

            // if there are dryer loads
            if (machineInfo.dryers.Count > 0)
            {
                // change groupbox visibility
                this.currentLoadsDryerGroupBox1.Enabled = true;
                this.currentLoadsDryerGroupBox1.Visible = true;
                // add dryer load info
                this.groupBox3LaundromatLabel.Text = machineInfo.dryers[0].location;
                this.groupBox3MachineLabel.Text = machineInfo.dryers[0].machineName;
                this.groupBox3TimeLabel.Text = machineInfo.dryers[0].loadInterval.ToString();
                if (machineInfo.dryers.Count > 1)
                {
                    // change groupbox visibility
                    this.currentLoadsDryerGroupBox2.Enabled = true;
                    this.currentLoadsDryerGroupBox2.Visible = true;
                    // add dryer load info
                    this.groupBox4LaundromatLabel.Text = machineInfo.dryers[1].location;
                    this.groupBox4MachineLabel.Text = machineInfo.dryers[1].machineName;
                    this.groupBox4TimeLabel.Text = machineInfo.dryers[1].loadInterval.ToString();
                }
            }
        }

        // tool strip button event handlers
        private void HomeToolStripButtonButton__Click(object sender, EventArgs e)
        {
            Home homepageForm = new Home();
            homepageForm.ShowDialog();
        }

        private void AvailabilityToolStripButton__Click(object sender, EventArgs e)
        {
            AvailabilityForm availabilityForm = new AvailabilityForm();
            availabilityForm.ShowDialog();
        }

        private void HistoryToolStripButton__Click(object sender, EventArgs e)
        {
           // Form2 historyForm = new Form2();
           // historyForm.ShowDialog();
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