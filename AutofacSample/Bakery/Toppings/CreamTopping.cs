using AutofacSample.Bakery.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacSample.Bakery.Toppings
{
    class CreamTopping : Topping
    {
        public CreamTopping(IOutput output, int identity) : base("cream", identity, output)
        {
        }
    }
}
