using System;

namespace HW07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста введите ваше стихотворение в одну строку разделяя ;");
            string stix = Console.ReadLine();
            stix = stix.Replace('a', 'o');
            stix = stix.Replace('а', 'o');
            string[] mas = stix.Split(';');
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
        }
    }
}
