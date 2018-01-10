using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Animal
    {
        public string Name;  
        public string Sound;
        public void MakeSound()
        {
            Console.WriteLine(this.Name + " makes " + this.Sound);
        }
        public Animal(string animalName)
        {
            this.Name = animalName;
        }
    }
}
  
    

