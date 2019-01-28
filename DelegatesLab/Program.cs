using System;

namespace DelegatesLab
{
    class Program
    {
        public delegate void Notify(string message);

        static void Main(string[] args)
        {
            Notify notifier = (m) => { Console.WriteLine(m); };

            WorkStarted(notifier);
            WorkFinished(notifier);

        }

        static public void WorkStarted(Notify notify)
        {
            notify("started");
        }

        static public void WorkFinished(Notify notify)
        {
            notify("Finished");
        }

        //public delegate int Calculation(int x, int y);

        //static void Main(string[] args)
        //{
        //    Calculation calc = Plus;

        //    var result1 = calc(2, 3);

        //    calc = Multiply;
        //    var result2 = calc(2, 3);

        //    calc=(2,3)=>{ 2 - 3; };

        //    Console.WriteLine($" Result1 : {result1} \n result2 : {result2}");
        //}

        //static public int Plus(int x,int y)
        //{
        //    return x + y;
        //}

        //static public int Multiply(int x, int y)
        //{
        //    return x * y;
        //}
    }
}
