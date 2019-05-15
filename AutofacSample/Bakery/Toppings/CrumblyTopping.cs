using AutofacSample.Bakery.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacSample.Bakery.Toppings
{
    class CrumblyTopping : Topping
    {
        public CrumblyTopping(IOutput output, int identity) : base("crumbly", identity, output)
        {
        }
    }
}
