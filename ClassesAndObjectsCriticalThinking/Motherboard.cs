using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsCriticalThinking
{
    class Motherboard // printed circuit board - allows CPU, RAM, and all other computer hardware components to communicate w/each other
    {
        // member variables (HAS A)
        public string manufacturer;
        public CPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;
        public GPU graphics;
       


        // constructor (SPAWNER)

        public Motherboard(string manufacturer, CPU cpu, RAM ram, HardDrive hardDrive, GPU gpu)
        {
            this.manufacturer = manufacturer;
            processor = cpu;
            temporaryMemory = ram;
            storage = hardDrive;
            graphics = gpu;
        }

        // methods (CAN DO)
        public void InstallApplication(Applications applicationsObject)
        {
            // take an Application object as a parameter
            //add application to ApplicationInHardDrive variable in HardDrive

            Applications application = applicationsObject;

            if (temporaryMemory.totalGigabytes > application.requireRAM && storage.totalStorage > application.requireStorage)
            { 
                storage.applicationsInHardDrive.Add(application);
            }
           
        }



    }
}
