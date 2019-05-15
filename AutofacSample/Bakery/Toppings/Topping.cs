using AutofacSample.Bakery.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacSample.Bakery.Toppings
{
    public abstract class Topping
    {
        private readonly IOutput _output;

        protected Topping(string name, int toppingIdentity, IOutput output)
        {
            this.Name = name;
            ToppingIdentity = toppingIdentity;
            this._output = output;
        }

        public string Name { get; }

        public int ToppingIdentity { get; }

        public virtual void Print()
        {
            _output.Print($"   - {Name} topping and identity {ToppingIdentity}");
        }
    }
}
