using AutofacSample.Bakery.Toppings;
using AutofacSample.Bakery.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacSample.Bakery
{
    class CookieFabric<T> : ICookieFabric where T: Topping
    {
        private readonly IOutput _output;
        private readonly IToppingSupplier<T> _toppingSupplier;

        public CookieFabric(IOutput output, IToppingSupplier<T> toppingSupplier)
        {
            this._output = output;
            this._toppingSupplier = toppingSupplier;
        }

        public void Bake(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _output.Print($"Put cookie number {i} into oven with:");
                _toppingSupplier.GetTopping().Print();
            }
        }
    }
}
