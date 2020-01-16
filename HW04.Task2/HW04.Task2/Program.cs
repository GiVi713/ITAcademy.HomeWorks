using System;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            char button = Convert.ToChar(Console.Read());
            if (button == 'w' || button == 'W')
            {
                Console.WriteLine("Ваш персонаж сделал шаг вперед"); return;
            }
            if (button == 's' || button == 'S')
            {
                Console.WriteLine("Ваш персонаж сделал шаг назад"); return;
            }
            if (button == 'a' || button == 'A')
            {
                Console.WriteLine("Ваш персонаж повернул налево"); return;
            }
            if (button == 'd' || button == 'D')
            {
                Console.WriteLine("Ваш персонаж повернул направо");return;
            }
            else
            {
                Console.WriteLine("Ваш персонаж решил что ему и здесь неплохо");
                // Здесь также могла быть конструкция через if (button !='w' & button !='s' & button !='a' & button !='')    
            }
        }
    }
}

