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
            Console.WriteLine("Наркотики, оружие и другие запрещенные предметы везете ?\n");
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
                Console.WriteLine("Повторяю");
                CheckLuggage();
            }
        }
        
        public void DontJokeWithSecurity()
        {
            Console.WriteLine("\nПройдемте со мной на более тщательный осмотр. После двухчасового " +
                "осмотра с допросом вы поняли что шутить с таможней была плохая идея.");
        }

        public void StandardProcedure()
        {
            Console.WriteLine("\nПоложите пожалуйста ваш багаж на ленту, достаньте все " +
                "металлические предметы из карманов и пройдите через металлодетектор.");
            Console.ReadLine();
            NonStandardSituations fortune = new NonStandardSituations();
            fortune.Beep();
            fortune.Lottery();
            fortune.AirCrush();
            Program theEnd = new Program();
            theEnd.Finish();
        }  
    }
}
