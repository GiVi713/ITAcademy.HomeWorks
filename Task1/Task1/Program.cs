using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] mas1 = new int[1];
        }
        static void Task2(string[] args)
        {
            var mas2 = new object [3];
            mas2[0] = 32;
            mas2[1] = 'A';
            mas2[2] = "Hello";
            Console.WriteLine((int)mas2[0] + 10);
            Console.WriteLine(mas2[2] + ", guys");
        }
        static void Task3(string[] args)
        {
            int[] mas3 = new int[13];
            Random rand = new Random();
            int max = 0;
            for (int i = 0; i < 13; i++)
            {
                mas3[i] = rand.Next();
                Console.WriteLine(mas3[i]);
                if(mas3[i] > max)
                {
                    max = mas3 [i];
                } 
            }Console.WriteLine(max);
        }
    }
}


