using Autofac;
using AutofacSample.Bakery;
using System;

namespace AutofacSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder cb = new ContainerBuilder();

            cb.RegisterModule<BakeryModule>();

            var container = cb.Build();

            var store = container.Resolve<Store>();
            store.Order();

            Console.WriteLine("Press enter to move to the next store...");
            Console.ReadLine();
            Console.Clear();

            var massStore = container.Resolve<MassStore>();
            massStore.Order();
        }
    }
}
