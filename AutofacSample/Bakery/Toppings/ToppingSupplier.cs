using AutofacSample.Bakery.Util;
using System;

namespace AutofacSample.Bakery.Toppings
{
    class ToppingSupplier<T> : IToppingSupplier<T> where T : Topping
    {
        private readonly IOutput _output;
        private readonly Func<int, T> _toppingFactory;

        private int _itemNumber = 0;

        public ToppingSupplier(IOutput output, Func<int, T> toppingFactory)
        {
            this._output = output;
            this._toppingFactory = toppingFactory;
        }

        public T GetTopping()
        {
            _output.Print("... supplier adds item number to the requested cookie");
            return _toppingFactory(_itemNumber++);
        }
    }
}
