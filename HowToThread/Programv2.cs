using System;
using static System.Console;
using System.Threading;
using System.Numerics;

namespace HowToThread
{
    public partial class Program
    {
        public static void MainMethod()
        {
            for (int i = 0; i <= 100; i++)
            {
                WriteLine("Main thread execution state: " + i + "%");
            }
        }

        private static void Silnia(int s)
        {
            BigInteger wynik = 1;
            WriteLine("Main thread has started. ");
            for (BigInteger i = 1; i <= s; i++)
            {
                wynik *= i;
            }
            WriteLine("Main thread has finished its work with following result: " + wynik);
        }
    }
}
