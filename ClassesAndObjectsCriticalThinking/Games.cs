using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsCriticalThinking
{
    class Games : Applications
    {
        // member variable (HAS A)
        public double requiredEffectiveMemory;
       

        // constructor (SPAWNER)
        public Games(double requiredEffectiveMemory)
        {
               this.requiredEffectiveMemory = requiredEffectiveMemory;
        }


        // methods (CAN DO)


    }
}
