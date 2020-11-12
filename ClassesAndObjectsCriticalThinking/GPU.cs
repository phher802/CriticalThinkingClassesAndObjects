using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsCriticalThinking
{
    class GPU //graphics processing unit: handles graphic ops for computer, primarily for 3D calculations
    {
        // member variables (HAS A)
        public string manufacturer;
        public double effectiveMemory;

        // constructor (SPAWNER)
        public GPU(string manufacturer, double effectiveMemory)
        {
            this.manufacturer = manufacturer;
            this.effectiveMemory = effectiveMemory;
        }


        // methods (CAN DO)

        public void GameInstall(Games requiredEffectiveMemory, HardDrive hardDrive, RAM ram)
        {
            Games game = requiredEffectiveMemory;
            hardDrive.gamesInHardDrive.Add(requiredEffectiveMemory);

        }

        public bool CheckMemory(Games requiredEffectiveMemory, HardDrive hardDrive, RAM ram)
        {
            if (ram.totalGigabytes > requiredEffectiveMemory.requireRAM && hardDrive.totalStorage > requiredEffectiveMemory.requireStorage)
            {
                GameInstall(requiredEffectiveMemory, hardDrive, ram);
            }

            return true;
        }
    }
}
