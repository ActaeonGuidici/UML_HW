using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_HW_2.Abstract;

namespace UML_HW_2.Concreate.RedBull
{
    internal class FruitRedBull : IRedBull
    {
        public FruitRedBull()
        {
            Console.WriteLine("Fruit RedBull");
        }
        public bool isLiquid { get; set; }
        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}
