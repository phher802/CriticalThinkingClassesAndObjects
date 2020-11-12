using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsCriticalThinking
{
    public abstract class Applications
    {
        // member variables (HAS A)
        public string applicationName;
        public string applicationType;
        public double requireRAM;
        public double requireStorage;

        // constructor (SPAWNER)
        public Applications()
        {
            applicationName = "Slack";
            applicationType = "Messageing Service";
            requireRAM = 4.0; //in gigaytes
            requireStorage = 0.512; //in gigabytes

        }

        // methods (CAN DO)


    }
}
