﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Pig : Animal
    {
        public Pig(string pigName)
            : base(pigName)
        {
            this.Sound = "Oink-oink-oink";
        }
    }
}