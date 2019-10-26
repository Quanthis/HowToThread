using System;
using static System.Console;
using System.Threading;

namespace HowToThread
{
    public partial class Program
    {        
        

        public static void Main(string[] args)
        {
            WriteLine("Main thread will also be doing something I guess");

            var t00 = new ThreadMethods(0);
            var t01 = new ThreadMethods(1);
            var t02 = new ThreadMethods(2);
            var t03 = new ThreadMethods(3);

            Thread t1 = new Thread(() => t00.ReallyHeavyThread(1000000));
            Thread t2 = new Thread(() => t01.ReallyHeavyThread(1000000));
            Thread t3 = new Thread(() => t02.ReallyHeavyThread(1000000));
            Thread t4 = new Thread(() => t03.ReallyHeavyThread(1000000));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            silnia(1000000);

            /*Thread t2 = new Thread(() => ThreadMethods.staticThread());

            t1.Start();
            t2.Start();
            MainMethod();

            t1.Join();
            t2.Join(); */

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();

            ReadKey();
        }
    }
}
