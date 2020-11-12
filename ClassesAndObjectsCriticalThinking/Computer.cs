using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsCriticalThinking
{
    class Computer
    {
        // member variables 
        public CPU cpu = new CPU("Apple", "Apple");
        public RAM ram = new RAM(16, "Apple");
        public HardDrive hardDrive = new HardDrive(500, 400);
        public GPU gpu = new GPU("Apple", 50);

        // constructor
        public Computer()
        {
            Motherboard motherboard = new Motherboard("Apple", cpu, ram, hardDrive, gpu);


        }

        //methods (can do)
        public void Installations()
        {
            HardDrive hardDrive = new HardDrive(2, 2);
            RAM ram = new RAM(1, "Sony");
            Games game = new Games(50);

            gpu.GameInstall(game, hardDrive, ram);

        }
      
     
    }


}

  



    }
}
