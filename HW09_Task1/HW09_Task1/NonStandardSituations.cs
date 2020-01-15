using System;
using System.Collections.Generic;
using System.Text;
using HW09_Task1.Control;

namespace HW09_Task1
{
    public class NonStandardSituations
    {
        public void Beep()
        {
            Random fate = new Random();
            int detector = fate.Next(1, 50);
            if (detector > 7)
            {
                Console.WriteLine("Все в порядке, проходите. Приятного полета.\n");
            }
            else
            {
                Console.WriteLine("Пожалуйста подойдите и вытяните руки в стороны.");
                Console.ReadLine();
                Console.WriteLine("Хорошо проходите. Приятного полета.\n");
            }
        }
        public void Lottery()
        {
            Random lottery = new Random();
            int lucky = lottery.Next(1, 100);
            if (lucky == 13)
            {
                Console.WriteLine("Вы попались на перевозке наркотиков в особо крупном размере." +
                    "Вам дали 10 лет и естественно вы никуда не полетели. ");
            }
        }
        public void AirCrush()
        {
            Random crush = new Random();
            int lucky = crush.Next(1, 1_000_000);
            if ( lucky == 666)
            {
                Console.WriteLine("Вспышка на солнце вызвала возгорание двигателей, самолет потерял" +
                    "управление и упал в Тихом океане. Никто не выжил. ='(");
            }
        }
    }
}
