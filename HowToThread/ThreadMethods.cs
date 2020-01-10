using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;
using System.Numerics;

namespace HowToThread
{
    public class ThreadMethods
    {
        int n;

        public ThreadMethods(int threadNumber)
        {
            n = threadNumber;
        }
       
        public void Thread1()
        {
            for (int i = 0; i <= 100; i++)
            {
                WriteLine($"Thread{n} execution state: {i}%");
            }
        }

        public static void staticThread()
        {
            for (int i = 0; i <= 100; i++)
            {
                WriteLine($"Thread execution state: {i}%");
            }
        }

        private void Silnia(int f)
        {
            WriteLine($"Thread {n} execution started.");
            BigInteger wynik = 1;

            for (BigInteger i = 1; i <= f; i++)
            {
                wynik *= i;                
            }
            WriteLine($"Thread {n} has finished its work with following result: ");
        }

        public void ReallyHeavyThread(int d)
        {
            Silnia(d);
        }
    }
}
