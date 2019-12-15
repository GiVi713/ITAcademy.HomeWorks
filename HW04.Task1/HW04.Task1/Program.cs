using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int bigletters = 90; bigletters <= 90 && bigletters >= 65; bigletters--)
            {
                Console.WriteLine(Convert.ToChar(bigletters));
            }
            for (int smallletters = 122; smallletters <= 122 && smallletters >= 97; smallletters--)
            {
                Console.WriteLine(Convert.ToChar(smallletters));
            }
        }
    }
}
