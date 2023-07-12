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
    internal class NormalFactory : IDrinkFactory
    {
        public ICola CreateCola() => new NormalCola();
        public IPepsi CreatePepsi() => new NormalPepsi();
        public ISandora CreateSandora() => new NormalSandora();
        public IRedBull CreateRedBull() => new NormalRedBull();
    }
}
