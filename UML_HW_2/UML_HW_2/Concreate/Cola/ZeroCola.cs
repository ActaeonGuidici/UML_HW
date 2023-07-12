using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_HW_2.Abstract;

namespace UML_HW_2.Concreate
{
    internal class ZeroCola : ICola
    {
        public ZeroCola()
        {
            Console.WriteLine("Zero Cola");
        }

        public bool isLiquid { get; set; }

        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}
