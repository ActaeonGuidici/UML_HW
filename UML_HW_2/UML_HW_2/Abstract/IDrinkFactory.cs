using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_HW_2.Abstract
{
    internal interface IDrinkFactory
    {
        ICola CreateCola();
        IRedBull CreateRedBull();
        ISandora CreateSandora();
        IPepsi CreatePepsi();
    }
}
