using System;
using System.Drawing;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Size = 25;
            Random rand = new Random();
            int[] randnum = new int[Size];      
            for (int i = 0; i < Size; i++)
            {
                randnum[i] = rand.Next(0,6000);
                Console.WriteLine(randnum[i]);
            }
            int[] ournum = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                ournum[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] sum = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                sum[i] = randnum[i] + ournum[i];
                Console.WriteLine(sum[i]);
            }
        }
    }
}
