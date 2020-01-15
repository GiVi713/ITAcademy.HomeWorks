using System;
using System.Collections.Generic;
using System.Text;

namespace HW09_Task1
{
    public class NewPassenger
    {
        public void RegisterPassenger()
        {
            Console.WriteLine("Пожалуйста скажите вашу фамилию и имя");
            Name = Console.ReadLine();
            Console.WriteLine(_name);
        }
        private string _name;  
        public string Name 
        {
            get => _name;
            set => _name = value;
        }
    }
}
