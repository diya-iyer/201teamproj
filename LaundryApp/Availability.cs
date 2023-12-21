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
    // Author: Neme Velazquez
    // Purpose: Provide a quick view into the state of laundry facilities around campus
    public partial class AvailabilityForm : Form
    {
        // fields/variables needed for other form's constructors
        public List<WashLoad> selectedWasherList = new List<WashLoad>();
        public List<DryLoad> selectedDryerList = new List<DryLoad>();

        // form constructor
        public AvailabilityForm()
        {
            InitializeComponent();

            //nav bar button handlers
            this.homeButton.Click += new EventHandler(HomeButton__Click);
            this.historyButton.Click += new EventHandler(HistoryButton__Click);
            this.reportButton.Click += new EventHandler(ReportButton__Click);

            //picture box event handlers
            this.hallDropDownButton.DropDownItemClicked += new ToolStripItemClickedEventHandler(HallDropDownButton__ItemClicked);
        }

        private void HomeButton__Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(selectedWasherList, selectedDryerList);
            home.ShowDialog();
        }

        private void HistoryButton__Click(object sender, EventArgs e)
        {
            this.Hide();
            History history = new History(selectedWasherList, selectedDryerList);
            history.ShowDialog();
        }

        private void ReportButton__Click(object sender, EventArgs e)
        {
            this.Hide();
            // Bright has not added this at the time of posting but will be updated if that changes
        }

        //changes map image location, dropdown text and label text based on the json
        private void HallDropDownButton__ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            this.hallDropDownButton.Text = item.Text;
            switch (item.Text)
            {
                case "Eugene Colby":
                case "Frances Baker":
                case "Fredericka Douglass":
                case "Helen Fish":
                case "Peter Peterson":
                case "Res Hall A":
                case "Res Hall B":
                case "Res Hall C":
                case "Res Hall D":
                    this.mapPictureBox.ImageLocation = "https://people.rit.edu/nav7977/unknown-map.png";
                    this.label1.Text = "?";
                    this.label2.Text = "?";
                    this.label5.Text = "?";
                    this.label6.Text = "?";
                    this.label7.Text = "?";
                    this.label8.Text = "?";
                    break;
                case "Carlton Gibson":
                    this.mapPictureBox.ImageLocation = "https://people.rit.edu/nav7977/gibsHall.png";
                    this.label1.Text = "1";
                    this.label2.Text = "2";
                    this.label5.Text = "2";
                    this.label6.Text = "1";
                    this.label7.Text = "0";
                    this.label8.Text = "0";
                    break;
                case "Kate Gleason":
                    this.mapPictureBox.ImageLocation = "https://people.rit.edu/nav7977/gleasHall.png";
                    this.label1.Text = "3";
                    this.label2.Text = "3";
                    this.label5.Text = "1";
                    this.label6.Text = "2";
                    this.label7.Text = "0";
                    this.label8.Text = "0";
                    break;
                case "Mark Ellingson":
                    this.mapPictureBox.ImageLocation = "https://people.rit.edu/nav7977/ellHall.png";
                    this.label1.Text = "3";
                    this.label2.Text = "3";
                    this.label5.Text = "2";
                    this.label6.Text = "2";
                    this.label7.Text = "0";
                    this.label8.Text = "0";
                    break;
                case "Sol Heumann":
                    this.mapPictureBox.ImageLocation = "https://people.rit.edu/nav7977/solHall.png";
                    this.label1.Text = "1";
                    this.label2.Text = "3";
                    this.label5.Text = "2";
                    this.label6.Text = "0";
                    this.label7.Text = "0";
                    this.label8.Text = "1";
                    break;
            }
        }
    }
}
