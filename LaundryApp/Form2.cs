using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json; //for json additions



/*
 * Tyler Aluko
 * IGME.201 - Team Project
 * History Log
 * ...
 * (will update this code once someone is available to edit the designer, but here are the basics for now)
 */
namespace LaundryApp
{


    public partial class History : Form
    {
        
        private List<LaundryLoad> laundryLoads; //list stores load history

        public History(List<LaundryLoad> loads)
        {
            
            InitializeComponent();
            
            laundryLoads = loads;

            PopulateHistoryGrid(); //method to populate DataGridView w/ provided loads

        }

        private void PopulateHistoryGrid()
        {
            
            //assuming dataGridView is the name of your DataGridView control on the form
            dataGridView.Rows.Clear();

            foreach (LaundryLoad load in laundryLoads)
            { //for each laundry load
                //add row to DataGridView
                dataGridView.Rows.Add(load.Date, load.Time, load.Location, load.MachineSettings, load.MachineID);
            }

        }

    }


}
