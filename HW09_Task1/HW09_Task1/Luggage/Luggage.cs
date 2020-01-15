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

            Console.WriteLine("Скажите пожалуйста сколько сумок и есть ли ручная кладь у вас?");
            string personLuggage = Console.ReadLine();
            
           if (personLuggage == "Еду без багажа")
            {
                LuggageCalc();
            }
            else if ( personLuggage == "Одна сумка")
            {
                LuggageCalc("Одна сумка");
            }
            else if ( personLuggage == "Cумка и ручная кладь")
            {
                LuggageCalc("Сумка(и)", "Ручная кладь");
            }
        }

        public void LuggageCalc()
        {
            NewPassenger luggage = new NewPassenger();
            string personName = luggage.Name;
            Console.WriteLine($"Что ж,{personName},вот ваш билет, вам осталось пройти службу " +
                                                                                  $"безопасности") ;
        }

        public void LuggageCalc(string Bag)
        {
            Random weight = new Random();
            Console.WriteLine($"Вес вашего багажа {weight.Next(1,25)} килограмм, все в порядке. Вот ваш билет " +
                $",вам осталось пройти службу безопасности. Хорошего полета.");
        }

        public void LuggageCalc(string Bag,string handBag)
        {
            Random weight = new Random();
            Console.WriteLine($"Вес вашего багажа {weight.Next(1, 25)}килограмм,а вес ручной клади " +
                      $"{weight.Next(1, 7)} килограмм, все в порядке. Вот ваш билет ," +
                      $" вам осталось пройти службу безопасности. Хорошего вам полета.");
        }
    }
}
