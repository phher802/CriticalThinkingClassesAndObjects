using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsCriticalThinking
{
    class RAM //random-access memory: devices' short-term membory; temporarily stores/remembers everything that runs on PC e.g. windows, webit browser, game, etc.
    {
        // member variables (HAS A)
        public double totalGigabytes;
        public string brand;

        // constructor (SPAWNER)
        public RAM(double totalGB, string brand)
        {
            totalGigabytes = totalGB;
            this.brand = brand;
        }

        // method (CAN DO)



    }
}
