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
    /* 
     Machine Information Module 
     Diya Iyer
     Module for the user to register a load and input their laundry settings
     */
    public partial class MachineInfo : Form
    {
        public List<WashLoad> washers = new List<WashLoad>(); // list of all the washers in the selected location
        public List<DryLoad> dryers = new List<DryLoad>(); // list of all the dryers in the selected location 
        WashLoad selectedWasher = null; // the washing machine the user is registering 
        DryLoad selectedDryer = null; // the dryer the user is registering
        public List<WashLoad> selectedWasherList = new List<WashLoad>(); // a list of all the washing machines registered by the user
        public List<DryLoad> selectedDryerList = new List<DryLoad>(); // a list of all the dryers registered by the user
        int currentLoadTime = 0; // the estimated time to complete the washing or drying of the load

        // constructor gets passed the location the user selected on the homepage
        public MachineInfo(string location)
        {
            InitializeComponent();
            LoadFormDetails(location);

            // event handlers
            this.washRadioButton.CheckedChanged += new EventHandler(WashRadioButton__CheckedChanged);
            this.dryerRadioButton.CheckedChanged += new EventHandler(DryerRadioButton__CheckedChanged);
            this.machineNumberComboBox.SelectedValueChanged += new EventHandler(MachineNumberComboBox__SelectedValueChanged);
            this.setting1ComboBox.SelectedValueChanged += new EventHandler(Setting1ComboBox__SelectedValueChanged);
            this.setting2ComboBox.SelectedValueChanged += new EventHandler(Setting2ComboBox__SelectedValueChanged);
            this.startButton.Click += new EventHandler(StartButton__Click);

            // navigation event handlers
            this.homeButton.Click += new EventHandler(HomeButton__Click);
            this.availabilityButton.Click += new EventHandler(AvailabilityButton__Click);
            this.historyButton.Click += new EventHandler(HistoryButton__Click);
            this.reportButton.Click += new EventHandler(ReportButton__Click); 
        }

        private void HomeButton__Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeForm = new Home(selectedWasherList, selectedDryerList);
            homeForm.ShowDialog();
        }

        private void AvailabilityButton__Click(object sender, EventArgs e)
        {
            this.Hide(); 
            AvailabilityForm availForm = new AvailabilityForm();
            availForm.ShowDialog();
        }

        private void HistoryButton__Click(object sender, EventArgs e)
        {
            this.Hide();
            History historyForm = new History(selectedWasherList, selectedDryerList);
            historyForm.ShowDialog();
        }

        private void ReportButton__Click(object sender, EventArgs e)
        {
            this.Hide();
            // the report form never made it into this project, when it is added, it'll be linked here
        }

        // loads the details of all the available machines and their settings to be displayed in drop downs
        // takes one argument of the selected location 
        private void LoadFormDetails(string location)
        {
            // reading the JSON file containing washing machine details as a stream
            StreamReader reader = new StreamReader("./washingmachines.json");
            string washerStr = reader.ReadToEnd();
            reader.Close();

            // reading the JSON file containing drying machine details as a stream
            reader = new StreamReader("./dryingmachines.json");
            string dryerStr = reader.ReadToEnd();
            reader.Close();

            // Deserializing the object to place information on the machines into lists
            washers = JsonConvert.DeserializeObject<List<WashLoad>>(washerStr);
            dryers = JsonConvert.DeserializeObject<List<DryLoad>>(dryerStr);
        }

        private void WashRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            // checking which radio button was checked 
            if (this.washRadioButton.Checked)
            {
                setting2ComboBox.Visible = true;
                this.machineNumberComboBox.Items.Clear();
                this.setting1ComboBox.Items.Clear();
                this.setting2ComboBox.Items.Clear();

                // looping through the list containing all the washing machines and adding the available ones to the dropdown
                foreach (WashLoad washer in washers)
                {
                    if (washer != null && washer.available)
                    {
                        this.machineNumberComboBox.Items.Add(washer.machineName);
                    }
                }

                this.machineNumberComboBox.Enabled = true;

                // checking if all the required fields are filled to enable the start button 
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
            // checking that the correct radio button is checked
            if (this.dryerRadioButton.Checked)
            {
                this.machineNumberComboBox.Items.Clear();
                this.setting1ComboBox.Items.Clear();
                this.setting2ComboBox.Items.Clear();
                this.setting2ComboBox.Visible = false; // there is only one setting for dryers, so get rid of setting 2 dropdown

                // looping through the list containing all the drying machines and adding the available ones to the dropdown
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

                // loops through the available washers and adds their correct settings to the setting dropdowns
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
                // enables the dropdowns once the correct options have been added
                this.setting1ComboBox.Enabled = true;
                this.setting2ComboBox.Enabled = true;
            }
            else if (this.dryerRadioButton.Checked)
            {
                this.setting1ComboBox.Items.Clear();

                // loops through the available dryers and adds their correct settings to the setting dropdowns
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
            // displays the estimated time it will take for the load to finish based on the setting chosen
            if (this.washRadioButton.Checked)
            {
                foreach (WashLoad washer in washers)
                {
                    if (washer != null && washer.machineName.Equals(this.machineNumberComboBox.Text))
                    {
                        this.timeLabel.Text = washer.washTypeTime[this.setting1ComboBox.SelectedIndex] + " minutes";
                        this.currentLoadTime = washer.washTypeTime[this.setting1ComboBox.SelectedIndex];
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
                        this.currentLoadTime = dryer.dryTypeTime[this.setting1ComboBox.SelectedIndex];
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
            // checks if all the proper fields are filled out to enable the start button
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
            // adds all inputted information to the selectedWasher, which is then appended to a list to be sent to the other modules
            if (this.washRadioButton.Checked)
            {
                selectedWasher = new WashLoad();
                selectedWasher.machineName = this.machineNumberComboBox.Text;
                selectedWasher.selectedWashType = this.setting1ComboBox.Text;
                selectedWasher.selectedTemperature = this.setting2ComboBox.Text;
                selectedWasher.loadName = this.loadNameTextBox.Text;
                selectedWasher.loadInterval = this.currentLoadTime;
                selectedWasher.available = false;

                selectedWasherList.Add(selectedWasher);

                foreach (WashLoad washer in washers)
                {
                    if (washer != null && washer.machineName.Equals(this.machineNumberComboBox.Text))
                    {
                        washer.available = false;
                    }
                }
            }
            else if (this.dryerRadioButton.Checked)
            {
                selectedDryer = new DryLoad();
                selectedDryer.machineName = this.machineNumberComboBox.Text;
                selectedDryer.selectedDryType = this.setting1ComboBox.Text;
                selectedDryer.loadName = this.loadNameTextBox.Text;
                selectedDryer.loadInterval = this.currentLoadTime;
                selectedDryer.available = false;

                selectedDryerList.Add(selectedDryer);

                foreach (DryLoad dryer in dryers)
                {
                    if (dryer != null && dryer.machineName.Equals(this.machineNumberComboBox.Text))
                    {
                        dryer.available = false;
                    }
                }
            }

            // reset the form so that people can add another load if they wish 
            this.loadNameTextBox.ResetText();
            this.machineNumberComboBox.Items.Clear();
            this.setting1ComboBox.Items.Clear(); 
            this.setting2ComboBox.Items.Clear();
            this.timeLabel.ResetText();
            this.washRadioButton.Checked = false;
            this.dryerRadioButton.Checked = false;
            this.setting2ComboBox.Visible = true;
            this.machineNumberComboBox.Enabled = false;
            this.setting1ComboBox.Enabled = false;
            this.setting2ComboBox.Enabled = false;
            this.startButton.Enabled = false;
        }

    }
}
