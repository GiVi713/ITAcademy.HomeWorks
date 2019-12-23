using System;

namespace Exersice3
{
    class Program
    {
        static void Main(string[] args)
        {
            const Int64 size = 5;
            Random rand = new Random();
            Int64[] mas = new Int64[size];
            for (int  i = 0;  i < size;  i++)
            {
                mas[i] = rand.Next();
                //Array.Reverse(mas);
                Console.WriteLine(mas[i]);
            }
            Array.Reverse(mas);
            
        }
    }
}
