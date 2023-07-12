using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_HW_1.Abstract
{
    abstract class Logistic
    {
        public void Create()
        {
            Console.WriteLine("Create logic.");
        }

        public abstract IProduct CreateProduct();
    }
}