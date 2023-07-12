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
    internal class SparklingFactory : IDrinkFactory
    {
        public ICola CreateCola() => new SparklingCola();
        public IPepsi CreatePepsi() => new SparklingPepsi();
        public ISandora CreateSandora() => new SparklingSandora();
        public IRedBull CreateRedBull() => new SparklingRedBull();
    }
}
