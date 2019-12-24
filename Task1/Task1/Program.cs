using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[13];
            Random rand = new Random();
            for (int i = 0; i < 13; i++)
            {
                mas[i] = rand.Next();
                Console.WriteLine(mas[i]);
     
            
            }
        }
    }
}
