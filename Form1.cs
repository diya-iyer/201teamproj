using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReportPage
{
    public partial class ReportPage : Form
    {
        private List<WashingMachine> locationList;
        public ReportPage()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load JSON data into locationList
            string json = File.ReadAllText("./washingmachines.json");
            locationList = JsonConvert.DeserializeObject<List<WashingMachine>>(json);

            // Populate locationListBox with distinct locations
            foreach (var location in locationList.Select(m => m.Location).Distinct())
            {
                locationListBox.Items.Add(location);
            }
        }

        private void locationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear previous items from machineListBox
            machineListBox.Items.Clear();

            // Get the selected location
            string selectedLocation = locationListBox.SelectedItem?.ToString();

            if (selectedLocation != null)
            {
                // Filter machines based on selected location
                var machinesInLocation = locationList.FindAll(m => m.Location == selectedLocation);

                // Populate machineListBox with machine names
                foreach (var machine in machinesInLocation)
                {
                    machineListBox.Items.Add(machine.MachineName);
                }
            }
        }

        private void machineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected machine
            string selectedMachineName = machineListBox.SelectedItem?.ToString();

            if (selectedMachineName != null)
            {
                // Find the selected machine in the locationList
                var selectedMachine = locationList.Find(m => m.MachineName == selectedMachineName);

                // Set the availability property to false
                selectedMachine.Available = 0; // Assuming 0 represents false

                // Update the JSON file (optional)
                string updatedJson = JsonConvert.SerializeObject(locationList, Formatting.Indented);
                File.WriteAllText("washingmachines.json", updatedJson);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class WashingMachine
    {
        public string Location { get; set; }
        public string MachineName { get; set; }
        public int Available { get; set; }
        public List<string> WashType { get; set; }
        public List<string> Temperature { get; set; }
    }
}
    