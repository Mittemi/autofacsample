using AutofacSample.Bakery.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacSample.Bakery
{
    class MassStore : IStore
    {
        private readonly IOutput _output;
        private readonly IList<ICookieFabric> _fabrics;

        public MassStore(IOutput output, IList<ICookieFabric> fabrics)
        {
            this._output = output;
            _fabrics = fabrics;
        }

        public void Order()
        {
            _output.Print("We order 3 cookies from each frabric...");
            foreach (var fabric in _fabrics)
            {
                fabric.Bake(3);
            }
        }
    }
}
