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
    // Purpose: Provide a quick view into the
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

        private void HallDropDownButton__ItemClicked(object sender, EventArgs e)
        {
            //
        }
    }

    
}
