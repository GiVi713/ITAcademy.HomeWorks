using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Employee
    {
        const int num = 10;
        public string name;
        public int age;     
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
        private int priv = 19;
        protected int prot = 18;
        internal int intern = 17;
        protected internal int protint = 16;
        private protected int privprot = 15;
    }
}
