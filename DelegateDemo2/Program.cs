using System;

namespace DelegateDemo2
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            var x = 2;
            var y = 3;

            var calc = new Operation(Multiply);
            calc += new Operation(Add);


            var result = calc(x, y);

            Func<int, int, int> f1 = delegate(int x1,int y1) { return x1 - y1; } ;

            Func<int, int, int> f2 = (x2, y2) =>  x2 + y2;

            Action<int> a1 = x3 => Console.WriteLine(x3);
            a1.Invoke(5);


            result =f1(4, 5);
            
            Console.WriteLine($" Result : {result}");
        }

        static public int Add(int x,int y)
        {
            Console.WriteLine("1");
            return x + y;
        }

        static public int Multiply(int x, int y)
        {
            Console.WriteLine("2");
            return x * y;
        }
    }
}
