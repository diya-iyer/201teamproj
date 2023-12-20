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

        // keep track of old wash loads and old dry loads
        // helps display multiple loads and can help populate history module
        public static List<WashLoad> oldWashLoads = new List<WashLoad>();
        public static List<DryLoad> oldDryLoads = new List<DryLoad>();
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

            // if there are washer loads or dryer loads
            if ((currentWashLoads.Count > 0) || (currentDryLoads.Count > 0))
            {
                // if there is an old wash load, move it to the 2nd wash groupbox
                if (oldWashLoads.Count > 0)
                {
                    // change groupbox visibility
                    this.currentLoadsWasherGroupBox2.Enabled = true;
                    this.currentLoadsWasherGroupBox2.Visible = true;
                    //this.currentLoadsWasherGroupBox1.Enabled = true;
                    //this.currentLoadsWasherGroupBox1.Visible = true;
                    // add washer load info
                    this.currentLoadsWasherGroupBox2.Text = oldWashLoads[0].loadName;
                    this.groupBox2LaundromatLabel.Text = oldWashLoads[0].location;
                    this.groupBox2MachineLabel.Text = oldWashLoads[0].machineName;
                    this.groupBox2TimeLabel.Text = "Finishing at " + DateTime.Now.AddMinutes(Convert.ToDouble(oldWashLoads[0].loadInterval)).ToString("H:mm");
                }
                // if there is a current wash load
                if (currentWashLoads.Count > 0)
                {
                    this.currentLoadsWasherGroupBox1.Enabled = true;
                    this.currentLoadsWasherGroupBox1.Visible = true;
                    // insert the current load to the beginning of the old wash loads
                    oldWashLoads.Insert(0, currentWashLoads[0]);
                    // change groupbox visibility
                    this.currentLoadsWasherGroupBox1.Enabled = true;
                    this.currentLoadsWasherGroupBox1.Visible = true;
                    // add washer load info
                    this.currentLoadsWasherGroupBox1.Text = currentWashLoads[0].loadName;
                    this.groupBox1LaundromatLabel.Text = currentWashLoads[0].location;
                    this.groupBox1MachineLabel.Text = currentWashLoads[0].machineName;
                    this.groupBox1TimeLabel.Text = "Finishing at " + DateTime.Now.AddMinutes(Convert.ToDouble(currentWashLoads[0].loadInterval)).ToString("H:mm");
                }

                // if there is an old dry load, move it to the 2nd dry groupbox
                if (oldDryLoads.Count > 0)
                {
                    // change groupbox visibility
                    this.currentLoadsDryerGroupBox2.Enabled = true;
                    this.currentLoadsDryerGroupBox2.Visible = true;
                    //this.currentLoadsDryerGroupBox1.Enabled = true;
                    //this.currentLoadsDryerGroupBox1.Visible = true;
                    // add dryer load info
                    this.currentLoadsDryerGroupBox2.Text = oldDryLoads[0].loadName;
                    this.groupBox4LaundromatLabel.Text = oldDryLoads[0].location;
                    this.groupBox4MachineLabel.Text = oldDryLoads[0].machineName;
                    this.groupBox4TimeLabel.Text = "Finishing at " + DateTime.Now.AddMinutes(Convert.ToDouble(oldDryLoads[0].loadInterval)).ToString("H:mm");
                }
                // if there is a current dry load
                if (currentDryLoads.Count > 0)
                {
                    this.currentLoadsDryerGroupBox1.Enabled = true;
                    this.currentLoadsDryerGroupBox1.Visible = true;
                    // insert the current load to the beginning of the old dry loads
                    oldDryLoads.Insert(0, currentDryLoads[0]);
                    // change groupbox visibility
                    this.currentLoadsDryerGroupBox1.Enabled = true;
                    this.currentLoadsDryerGroupBox1.Visible = true;
                    // add dryer load info
                    this.currentLoadsDryerGroupBox1.Text = currentDryLoads[0].loadName;
                    this.groupBox3LaundromatLabel.Text = currentDryLoads[0].location;
                    this.groupBox3MachineLabel.Text = currentDryLoads[0].machineName;
                    this.groupBox3TimeLabel.Text = "Finishing at " + DateTime.Now.AddMinutes(Convert.ToDouble(currentDryLoads[0].loadInterval)).ToString("H:mm");
                }
            }

        }

        private void AvailabilityToolStripButton__Click(object sender, EventArgs e)
        {
            AvailabilityForm availabilityForm = new AvailabilityForm();
            availabilityForm.ShowDialog();
            this.Close();
        }

        private void HistoryToolStripButton__Click(object sender, EventArgs e)
        {
            History historyForm = new History(oldWashLoads, oldDryLoads);
            historyForm.ShowDialog();
            this.Close();
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
            if (this.laundromatComboBox.SelectedItem != null)
            {
                this.errorProvider.SetError(laundromatComboBox, "");
                MachineInfo machineInfo = new MachineInfo(this.laundromatComboBox.SelectedItem.ToString());
                machineInfo.ShowDialog();
                this.Close();

            }
            else
            {
                this.errorProvider.SetError(laundromatComboBox, "Please select a laundromat.");
            }
        }
    }
}

