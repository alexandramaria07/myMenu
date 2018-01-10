using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Horse : Animal
    { 
        public Horse(string horseName)
            : base(horseName)
        {
            this.Sound = "Ni-ha-haaa";
        }
    }
}
