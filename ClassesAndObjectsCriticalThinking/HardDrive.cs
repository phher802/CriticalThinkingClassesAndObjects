using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsCriticalThinking
{
    class HardDrive //stores any and all content for computer; Persistent data
    {
        // member variables (HAS A)
        public double totalStorage;
        public double availableStorage;
        public List<Applications> applicationsInHardDrive;
        public List<Games> gamesInHardDrive;

        // constructor (SPAWNER)
        public HardDrive(double totalStorage, double availStorage)
        {
            this.totalStorage = totalStorage;
            availableStorage = availStorage;

            gamesInHardDrive = new List<Games>();
            Games rollerCoasterTycoon = new Games();
            gamesInHardDrive.Add(rollerCoasterTycoon);

            
        }

        // methods (CAN DO)
        

    }
}
