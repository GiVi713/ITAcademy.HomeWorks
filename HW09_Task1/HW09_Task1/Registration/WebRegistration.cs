using System;
using System.Collections.Generic;
using System.Text;

namespace HW09_Task1
{
    public class WebRegistration
    {
        int regNumber;
        public void WebReg()
        {
            Console.WriteLine("Для завершении регистрации мне нужен ваш паспорт и билет");
            Console.ReadKey();
            Console.WriteLine("Хорошо. С документами у вас все в порядке. Давайте рзберемся " +
                                                                               "с вашим багажом");
        }
    }
}
