using System;
using System.Diagnostics;

namespace Exersice3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            const Int64 size = 100000000;
            Random rand = new Random();
            Int64[] mas = new Int64[size];
            for (int i = 0; i < size; i++)
            {
                mas[i] = rand.Next();
            }
            Int64[] reverse = mas;
            time.Start();
            Array.Reverse(reverse);
            time.Stop();
            Console.WriteLine("Встроенный Reverse метод: " + time.Elapsed);
            time.Reset();
            time.Start();
            for (Int64 i = size; i >= 0; i--)
            {
            } 
            time.Stop();
            Console.WriteLine("Мой Reverse метод: " + time.Elapsed);
        }
    }
}
