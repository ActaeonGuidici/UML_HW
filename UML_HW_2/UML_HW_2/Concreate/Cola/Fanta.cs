﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_HW_2.Abstract;

namespace UML_HW_2.Concreate.Cola
{
    internal class Fanta : ICola
    {
        public Fanta()
        {
            Console.WriteLine("Fanta");
        }
        public bool isLiquid { get; set; }

        public void Drink()
        {
            throw new NotImplementedException();
        }

    }
}
