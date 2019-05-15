using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacSample.Bakery.Toppings
{
    class ToppingsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CreamTopping>().AsSelf();
            builder.RegisterType<CrumblyTopping>().AsSelf();

            const string CreamFabricName = "cream";
            const string CrumblyFabricName = "crumbly";

            builder.RegisterType<CookieFabric<CreamTopping>>().Named<ICookieFabric>(CreamFabricName).AsImplementedInterfaces();
            builder.RegisterType<CookieFabric<CrumblyTopping>>().Named<ICookieFabric>(CrumblyFabricName).AsImplementedInterfaces();

            builder.RegisterGeneric(typeof(ToppingSupplier<>)).AsImplementedInterfaces();

            base.Load(builder);
        }
    }
}
