using System;

namespace HW_11.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Array[] mas = new Array[3];

            mas[0] = new Square("Sqaure", rand.Next(1, 10));
             
        }
    }
}
