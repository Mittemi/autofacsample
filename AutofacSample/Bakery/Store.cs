using Autofac.Features.AttributeFilters;
using AutofacSample.Bakery.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacSample.Bakery
{
    class Store : IStore
    {
        private readonly IOutput _output;
        private readonly ICookieFabric _creamCookieFabric;
        private readonly ICookieFabric _crumblyCookieFabric;

        public Store(IOutput output, [KeyFilter("cream")] ICookieFabric creamCookieFabric, [KeyFilter("crumbly")] ICookieFabric crumblyCookieFabric)
        {
            this._output = output;
            this._creamCookieFabric = creamCookieFabric;
            this._crumblyCookieFabric = crumblyCookieFabric;
        }

        public void Order()
        {
            _output.Print("We order 3 cookies from cream frabric...");
            _creamCookieFabric.Bake(3);
            _output.Print("We order 4 cookies from crumbly frabric...");
            _crumblyCookieFabric.Bake(4);
        }
    }
}
