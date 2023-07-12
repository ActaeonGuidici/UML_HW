using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_HW_2.Abstract;
using UML_HW_2.Concreate.Cola;
using UML_HW_2.Concreate.Pepsi;
using UML_HW_2.Concreate.Sandora;
using UML_HW_2.Concreate.RedBull;

namespace UML_HW_2.Concreate
{
    internal class FruitFactory : IDrinkFactory
    {
        public ICola CreateCola() => new Fanta();
        public IPepsi CreatePepsi() => new FruitPepsi();
        public ISandora CreateSandora() => new FruitSandora();
        public IRedBull CreateRedBull() => new FruitRedBull();
    }
}
