using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 123;int num2 = 100; int num3 = 30;double num4 = 55.53562;
            //Явные преобразования
            byte numbyte = (byte)(num1 + num2);
            double numdouble = (double) num2 / num3;
            int integer = (int)num4;
            Console.WriteLine("Явные преобразования " + numbyte +" "+ numdouble +" "+ integer);
            //Неявные преобразования
            int test1 = 713;
            double test2 = 7.13;
            char test3 = 'X';
            Console.WriteLine("Неявные преобразования " + test1 +" " + test2 +" "+ test3);
            //Упаковка
            object Q = num1;
            object W = num2;
            object E = num3;
            //Распаковка
            Q = 321;
            num1 = (int)Q;
            W = 1;
            num2 = (int)W;
            E = 3;
            num3 = (int)E;
            Console.WriteLine("Значения после распаковки " + num1 + " "+ num2 +" "+ num3);
        }
    }
}
