using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryMachines
{
    public abstract class Machine
    {
        public string machineName;
        public bool available;
        public string location;
        public string loadName;
        public int loadInterval;
        public DateTime startTime;

        public void SetStartTime()
        {
            this.startTime = DateTime.Now;
        }
        
    }
    public class WashLoad : Machine
    {
        public string[] washType;
        public int[] washTypeTime;
        public string[] temperature;

        public string selectedWashType;
        public string selectedTemperature;

    }

    public class DryLoad : Machine
    {
        public string[] dryType;
        public int[] dryTypeTime;

        public string selectedDryType;
    }
}
