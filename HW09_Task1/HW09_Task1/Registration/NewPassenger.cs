using System;
using System.Collections.Generic;
using System.Text;

namespace HW09_Task1
{
    public class NewPassenger
    {
        public void Client()
        {
            string regStatus = Console.ReadLine();
            if (regStatus == "Прошел")
            {
                Console.WriteLine();
                WebRegistration webReg = new WebRegistration();
                webReg.WebReg();
            }
            else if (regStatus == "Здесь")
            {
                Console.WriteLine();
                Console.WriteLine("Скажите пожалуйста ваше Имя и Фамилию\n");
                Name = Console.ReadLine();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nПростите я вас не поняла, уже прошли или будете регистрироваться здесь?\n");
                Client();
            }
        }
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
