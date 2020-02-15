using System;
using System.Collections.Generic;
using System.Text;
using HW09_Task1;

namespace HW09_Task1.Luggage
{
    public class PersonLuggage
    {
        public void Luggage() 
        {
            Console.WriteLine("Скажите пожалуйста сколько сумок и есть ли ручная кладь у вас?\n");
            string personLuggage = Console.ReadLine();
            
           if (personLuggage == "Еду без багажа")
            {
                LuggageCalc();
            }
            else if ( personLuggage == "Одна сумка")
            {
                LuggageCalc("Одна сумка");
            }
            else if ( personLuggage == "Сумка и кладь")
            {
                LuggageCalc("Сумка", "Ручная кладь");
            }
            else
            { 
                Luggage();
            }
        }

        public void LuggageCalc()
        {
            Console.WriteLine($"\nЧто ж вот ваш билет, вам осталось пройти службу " +
                                                    $"безопасности.Хорошего вам полета.\n") ;
        }

        public void LuggageCalc(string Bag)
        {
            Random weight = new Random();
            Console.WriteLine($"\nДавайте взвесим ваш багаж. Вес вашего багажа {weight.Next(1,25)} кг, все в порядке. Вот ваш билет " +
                $",вам осталось пройти службу безопасности. Хорошего полета.\n");
        }

        public void LuggageCalc(string Bag,string handBag)
        {
            Random weight = new Random();
            Console.WriteLine($"\nДавайте взвесим ваш багаж. Вес вашего багажа {weight.Next(1, 25)} кг, вес ручной клади " +
                      $"{weight.Next(1, 7)} кг, все в порядке. Вот ваш билет ," +
                      $" вам осталось пройти службу безопасности. Хорошего вам полета.\n");
        }
    }
}
