using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] mas = new object[3];
            mas[0] = "32";
            mas[1] = "A";
            mas[2] = "Hello";
            Console.WriteLine(mas[0]);
            Console.WriteLine(mas[2] + ", guys");
            }
        }
    }
}
