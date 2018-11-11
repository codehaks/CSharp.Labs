using System;

namespace Operators.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;

            int y = x ?? -1;

            // y=-1

            Console.WriteLine("Hello World!");
        }
    }
}
