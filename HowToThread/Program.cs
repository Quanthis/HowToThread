using System;
using static System.Console;
using System.Threading;

namespace HowToThread
{
    class Program
    {        
        public static void MainMethod()
        {
            for (int i = 0; i <= 100; i++)
            {
                WriteLine("Main thread execution state: " + i + "%");
            }
        }

        public static void Main(string[] args)
        {
            WriteLine("Main thread will also be doing something I guess");

            Thread t1 = new Thread(ThreadMethods.Thread1);
            Thread t2 = new Thread(() => ThreadMethods.Thread1(5));

            t1.Start();
            t2.Start();
            MainMethod();

            t1.Join();
            t2.Join();
        }
    }
}
