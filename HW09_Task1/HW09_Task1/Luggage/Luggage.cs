using System;
using System.Collections.Generic;
using System.Text;

namespace HW09_Task1.Luggage
{
    public class PersonLuggage
    {
        public void LuggageCalc()
        {
            Random weight = new Random();
            Console.WriteLine($"Вес вашего багажа {weight.Next(0,25)}, все в порядке вам осталось" +
                                                   $" пройти службу безопасности. Хорошего полета.");
        }
    }
}
