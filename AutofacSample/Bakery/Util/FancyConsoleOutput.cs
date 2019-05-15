using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacSample.Bakery.Util
{
    class FancyConsoleOutput : IOutput
    {
        private readonly Random rand = new Random(10);

        public void Print(string content)
        {
            Console.ForegroundColor = (ConsoleColor)(rand.Next(14) + 1);
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
