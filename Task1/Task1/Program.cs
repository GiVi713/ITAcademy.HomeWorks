using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[1];
        }
        static void Task2(string[] args)
        {
            object[] mas = { 32, 'A', "Hello" };
            Console.WriteLine(mas[0]);
            Console.WriteLine(mas[2] + ", guys");
        }
        static void Task3(string[] args)
        {
            int[] mas = new int[13];
            Random rand = new Random();
            int max = 0;
            for (int i = 0; i < 13; i++)
            {
                mas[i] = rand.Next();
                Console.WriteLine(mas[i]);
                if(mas[i] > max)
                {
                    max = mas [i];
                } 
            }Console.WriteLine(max);
        }
    }
}


