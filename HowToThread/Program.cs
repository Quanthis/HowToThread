using System;
using static System.Console;
using System.Threading;

namespace HowToThread
{
    public partial class Program
    {       

        public static void Main(string[] args)
        {
            var t00 = new ThreadMethods(0);
            var t01 = new ThreadMethods(1);
            var t02 = new ThreadMethods(2);

            Thread t1 = new Thread(() => t00.ReallyHeavyThread(10000));
            Thread t2 = new Thread(() => t01.ReallyHeavyThread(10000));
            Thread t3 = new Thread(() => t02.ReallyHeavyThread(10000));

            t1.Start();
            t2.Start();
            t3.Start();
            //Silnia(1000000);

            t1.Join();
            t2.Join();
            t3.Join();

            ReadKey();
        }
    }
}