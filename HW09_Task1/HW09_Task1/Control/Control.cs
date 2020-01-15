using System;
using System.Collections.Generic;
using System.Text;
using HW09_Task1;

namespace HW09_Task1.Control
{
    public class ControlPerson
    {
        public void CheckLuggage() 
        {
            Console.WriteLine("Здравсвуйте. Наркотики, оружие и другие запрещенные предметы везете ?");
            string answer = Console.ReadLine();
            if (answer == "Да")
            {
                DontJokeWithSecurity();
            }
            else if ( answer == "Нет")
            {
                StandardProcedure();
            }
            else
            {
                Console.WriteLine("Пожалуйста повторите");
                CheckLuggage();
            }
        }
        
        public void DontJokeWithSecurity()
        {
            Console.WriteLine("Пройдемте со мной на более тщательный осмотр. После двухчасового " +
                "осмотра с допросом вы поняли что шутить с таможней была плохая идея.");
        }

        public void StandardProcedure()
        {
            Console.WriteLine("Положите пожалуйста ваш багаж на ленту, достаньте все" +
                "металлические предметы из карманов и пройдите через металлодетектор");
            NonStandardSituations fortune = new NonStandardSituations();
            fortune.Beep();
            fortune.Lottery();
            
        }

        public void Finish()
        {
            Console.WriteLine("Вы успешно прошли контроль и сели на свой самолет. Полет выдался " +
                "отличный. Через 7 часов вы приземлились в солнечном Карибском заливе, а через " +
                    "8 уже на спали на пляже");
        }
    }
}
