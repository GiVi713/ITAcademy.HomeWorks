using System;
using System.Text;

namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {   
            string text = Console.ReadLine();
            Task1(text);
            Task2(text);
            Task3(text);
            Task4(text);
        }
        static void Task1(string text)
         {
           string test = "";
            int count = new int();
            string[] mas = text.Split(' ');
            for (int i = 0; i < mas.Length; i++)
            {
                if(mas[i].Length > test.Length)
                {
                    test = mas[i];
                    count = i;
                }
            }
            mas[count] = string.Empty;
        }
        static void Task2(string text)
        {
            string max = "";
            string min = "";
            string change ="";
            string[] mas = text.Split(' ');
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].Length > max.Length)
                {
                    max = mas[i];
                }
                if (mas[i].Length < max.Length)
                {
                    min = mas[i];
                }
            }
            change = max;
            max = min;
            min = change;
        }
        static void Task3(string text)
        {
            int count = 0;
            foreach (char item in text)
            {
                count++;
            }
        }
        static void Task4(string text)
        {
            string temp = "";
            string[] mas = text.Split(' ');
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = 0; j < mas.Length - 1; j++)
                {
                    if (mas[i].Length > mas[j + 1].Length)
                    {
                        temp = mas[i];
                        mas[i] = mas[j + 1];
                        mas[j + 1] = temp;
                    }
                }
            }
        }
    }
}