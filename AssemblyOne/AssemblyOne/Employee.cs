using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class Employee
    {
        const int constanta = 10;
        public string name;
        public int age;     
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
        private int priv = 19;
        protected int protect = 18;
        internal int intern = 17;
        protected internal int protintern = 16;
        private protected int privprotect = 15;
    }
}
