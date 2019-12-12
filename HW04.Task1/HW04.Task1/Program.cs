using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int letters = 90; letters <= 90 && letters >= 65; letters--)
            {
                Console.WriteLine(Convert.ToChar(letters));
            }
        }
    }
}
