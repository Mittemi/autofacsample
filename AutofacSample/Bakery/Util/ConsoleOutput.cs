using System;
using System.Collections.Generic;
using System.Text;

namespace AutofacSample.Bakery.Util
{
    class ConsoleOutput : IOutput
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }
    }
}
