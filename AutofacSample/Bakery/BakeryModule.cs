using Autofac;
using AutofacSample.Bakery;
using AutofacSample.Bakery.Util;

namespace AutofacSample
{
    internal class BakeryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<Bakery.Toppings.ToppingsModule>();

            // 1
            //builder.RegisterType<ConsoleOutput>().AsImplementedInterfaces();

            // 2
            //builder.RegisterType<FancyConsoleOutput>().AsImplementedInterfaces();

            // 3
            builder.RegisterType<FancyConsoleOutput>().AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<Store>().AsImplementedInterfaces().AsSelf();
            builder.RegisterType<MassStore>().AsImplementedInterfaces().AsSelf();
        }
    }
}