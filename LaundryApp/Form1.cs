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
    public partial class MachineInfo : Form
    {
        List<WashLoad> washers = new List<WashLoad>();
        List<DryLoad> dryers = new List<DryLoad>();
        WashLoad selectedWasher = null;
        DryLoad selectedDryer = null;
        List<WashLoad> selectedWasherList = new List<WashLoad>();
        List<DryLoad> selectedDryerList = new List<DryLoad>();
        public MachineInfo(string location)
        {
            InitializeComponent();
            LoadFormDetails(location);

            this.washRadioButton.CheckedChanged += new EventHandler(WashRadioButton__CheckedChanged);
            this.dryerRadioButton.CheckedChanged += new EventHandler(DryerRadioButton__CheckedChanged);
            this.machineNumberComboBox.SelectedValueChanged += new EventHandler(MachineNumberComboBox__SelectedValueChanged);
            this.setting1ComboBox.SelectedValueChanged += new EventHandler(Setting1ComboBox__SelectedValueChanged);
            this.setting2ComboBox.SelectedValueChanged += new EventHandler(Setting2ComboBox__SelectedValueChanged);
            this.startButton.Click += new EventHandler(StartButton__Click);

            
        }


        private void LoadFormDetails(string location)
        {
            StreamReader reader = new StreamReader("./washingmachines.json");
            string washerStr = reader.ReadToEnd();
            reader.Close();

           reader = new StreamReader("./dryingmachines.json");
            string dryerStr = reader.ReadToEnd();
            reader.Close();

            washers = JsonConvert.DeserializeObject<List<WashLoad>>(washerStr);
            dryers = JsonConvert.DeserializeObject<List<DryLoad>>(dryerStr);
        }

        private void WashRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (this.washRadioButton.Checked)
            {
                setting2ComboBox.Visible = true;
                this.machineNumberComboBox.Items.Clear();
                this.setting1ComboBox.Items.Clear();
                this.setting2ComboBox.Items.Clear();
                foreach (WashLoad washer in washers)
                {
                    if (washer != null && washer.available)
                    {
                        this.machineNumberComboBox.Items.Add(washer.machineName);
                    }
                }

                this.machineNumberComboBox.Enabled = true;

                if (this.machineNumberComboBox.SelectedItem != null &&
                   this.setting1ComboBox.SelectedItem != null &&
                   this.setting2ComboBox.SelectedItem != null &&
                   this.loadNameTextBox.Text.Trim().Length > 0)
                {
                    this.startButton.Enabled = true;
                }
            }
        }

        private void DryerRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (this.dryerRadioButton.Checked)
            {
                this.machineNumberComboBox.Items.Clear();
                this.setting1ComboBox.Items.Clear();
                this.setting2ComboBox.Items.Clear();
                this.setting2ComboBox.Visible = false;
                foreach (DryLoad dryer in dryers)
                {
                    if (dryer != null && dryer.available)
                    {
                        this.machineNumberComboBox.Items.Add(dryer.machineName);
                        
                    }
                }
                this.machineNumberComboBox.Enabled = true;

                if (this.machineNumberComboBox.SelectedItem != null &&
                   this.setting1ComboBox.SelectedItem != null &&
                   this.loadNameTextBox.Text.Trim().Length > 0)
                {
                    this.startButton.Enabled = true;
                }
            }
        }

        private void MachineNumberComboBox__SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.washRadioButton.Checked)
            {

                this.setting1ComboBox.Items.Clear();
                this.setting2ComboBox.Items.Clear();
                foreach (WashLoad washer in washers)
                {
                    if (washer != null && washer.machineName.Equals(this.machineNumberComboBox.Text))
                    {
                        foreach (string washType in washer.washType)
                        {
                            this.setting1ComboBox.Items.Add(washType);
                        }
                        foreach (string temperature in washer.temperature)
                        {
                            this.setting2ComboBox.Items.Add(temperature);
                        }
                    }
                }
                this.setting1ComboBox.Enabled = true;
                this.setting2ComboBox.Enabled = true;
            }
            else if (this.dryerRadioButton.Checked)
            {
                this.setting1ComboBox.Items.Clear();
                foreach (DryLoad dryer in dryers)
                {
                    if (dryer != null && dryer.machineName.Equals(this.machineNumberComboBox.Text))
                    {
                        foreach (string dryType in dryer.dryType)
                        {
                            this.setting1ComboBox.Items.Add(dryType);
                        }
                    }
                }
                this.setting1ComboBox.Enabled = true;
                this.setting2ComboBox.Visible = false;
            }

            if (this.machineNumberComboBox.SelectedItem != null &&
                  this.setting1ComboBox.SelectedItem != null &&
                  this.loadNameTextBox.Text.Trim().Length > 0)
            {
                this.startButton.Enabled = true;
            }

        }
        private void Setting1ComboBox__SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.washRadioButton.Checked)
            {
                foreach (WashLoad washer in washers)
                {
                    if (washer != null && washer.machineName.Equals(this.machineNumberComboBox.Text))
                    {
                        this.timeLabel.Text = washer.washTypeTime[this.setting1ComboBox.SelectedIndex] + " minutes";
                    }
                }
                if (this.machineNumberComboBox.SelectedItem != null &&
                  this.setting1ComboBox.SelectedItem != null &&
                  this.setting2ComboBox.SelectedItem != null &&
                  this.loadNameTextBox.Text.Trim().Length > 0)
                {
                    this.startButton.Enabled = true;
                }
            }
            else if (this.dryerRadioButton.Checked)
            {
                foreach (DryLoad dryer in dryers)
                {
                    if (dryer != null && dryer.machineName.Equals(this.machineNumberComboBox.Text))
                    {
                        this.timeLabel.Text = dryer.dryTypeTime[this.setting1ComboBox.SelectedIndex] + " minutes";
                    }
                }
                if (this.machineNumberComboBox.SelectedItem != null &&
                  this.setting1ComboBox.SelectedItem != null &&
                  this.loadNameTextBox.Text.Trim().Length > 0)
                {
                    this.startButton.Enabled = true;
                }
            }
            
        }
        private void Setting2ComboBox__SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.washRadioButton.Checked)
            {
                if (this.machineNumberComboBox.SelectedItem != null &&
                  this.setting1ComboBox.SelectedItem != null &&
                  this.setting2ComboBox.SelectedItem != null &&
                  this.loadNameTextBox.Text.Trim().Length > 0)
                {
                    this.startButton.Enabled = true;
                }
            }
        }
        private void StartButton__Click(object sender, EventArgs e)
        {
            if (this.washRadioButton.Checked)
            {
                selectedWasher = new WashLoad(); 
                selectedWasher.machineName = machineNumberComboBox.SelectedItem.ToString();
                selectedWasher.selectedWashType = setting1ComboBox.SelectedItem.ToString();
                selectedWasher.selectedTemperature = setting2ComboBox.SelectedItem.ToString();
                selectedWasher.loadName = loadNameTextBox.Text;
                selectedWasher.loadInterval = Int32.Parse(this.timeLabel.Text);

                selectedWasherList.Add(selectedWasher);
            }
            else if (this.dryerRadioButton.Checked)
            {
                selectedDryer = new DryLoad();
                selectedDryer.machineName = machineNumberComboBox.SelectedItem.ToString();
                selectedDryer.selectedDryType = setting1ComboBox.SelectedItem.ToString();
                selectedDryer.loadName = loadNameTextBox.Text;
                selectedDryer.loadInterval = Int32.Parse(this.timeLabel.Text);

                selectedDryerList.Add(selectedDryer);
            }
        }

    }
}
