﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_HW_1.Abstract;

namespace UML_HW_1
{
    internal class FoodLogic : Logistic
    {
        public override IProduct CreateProduct() => new Sausage();
    }
}
