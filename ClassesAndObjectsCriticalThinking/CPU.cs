using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsCriticalThinking
{
    class CPU  //central process unit; performs basic math, logic, controlling, input/output ops specified by instructions in program
    {
        // member variable (HAS A)
        public string manufacturer;
        public string name;


        // constructor (SPAWNER)
        public CPU(string manufacturer, string name)
        {
            this.manufacturer = manufacturer;
            this.name = name;
        }

        // methods (CAN DO)
        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            Applications application = app;
            hardDrive.applicationsInHardDrive.Add(application);
         
        }

        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            if (ram.totalGigabytes > app.requireRAM && hardDrive.totalStorage > app.requireStorage)
            {
                ProcessInstall(app, hardDrive, ram);
            }

            return true;
        }
    }
}
