using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Cat : Animal
    {
        public Cat(string catName) : base(catName)
        {
            this.Sound = "Meooooooow-meeeowww";
        }
    }
}
