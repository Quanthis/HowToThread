using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace HowToThread
{
    public class ThreadMethods
    {
        //zrobić konstruktor aby zczytywać numery wątków
        public static void Thread1(int number)
        {
            for (int i = 0; i <= 100; i++)
            {
                WriteLine($"Thread{number} execution state: {i}%");
            }
        }

        public static void Thread1()
        {
            for (int i = 0; i <= 100; i++)
            {
                WriteLine($"Thread execution state: {i}%");
            }
        }
    }
}
