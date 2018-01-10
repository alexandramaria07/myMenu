using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Dog : Animal
    {
        public Dog(string dogName) : base(dogName)
        {
            this.Sound = "Woof-wooof-wooof";
        }
    } 
}
