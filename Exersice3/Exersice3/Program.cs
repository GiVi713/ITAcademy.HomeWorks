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
            for (Int64 k = 0; k < size; k++)
            {
                mas[k] = rand.Next();
            }
            Int64[] reverse = mas;
            time.Start();
            Array.Reverse(reverse);
            time.Stop();
            Console.WriteLine("Встроенный Reverse метод: " + time.Elapsed);
            time.Reset();
            time.Start();
            Int64 i, j, t;
            for (i = 0 ,j = size -1 ; i < j; i++ , j--)
            {
                t = mas[i];
                mas[i] = mas[j];
                mas[j] = t;
            } 
            time.Stop();            
            Console.WriteLine("Мой Reverse метод: " + time.Elapsed);
        }
    }
}
