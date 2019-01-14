using System;
using System.Linq.Expressions;

namespace App.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Action> ex = () => Console.WriteLine("Hello from expression");

            //Expression<Action> ex2 = () => { Console.WriteLine("Hello from expression"); };

            Action ac = () =>
            {
                Console.WriteLine("from Action");
            };

            ac.Invoke();

            //Expression.Block()

            var result=ex.Compile();
       
            result.Invoke();
            
            Console.WriteLine("Hello World!");
        }
    }
}
