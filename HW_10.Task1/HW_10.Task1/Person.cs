using System;
using System.Collections.Generic;
using System.Text;

namespace HW_10.Task1
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Info;

        public Person(string _name, int _age)
        {
            Name = _name;
            Age = _age;
            Info = $"{Name}s age is {Age}";
        }
    }
}
