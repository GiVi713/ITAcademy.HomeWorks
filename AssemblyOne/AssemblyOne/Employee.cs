using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Employee
    {
        const int constanta = 10;
        public string name;    
        private int priv = 19;
        protected int protect = 18;
        internal int intern = 17;
        protected internal int protintern = 16;
        private protected int privprotect = 15;
    }
    public class Developer : Employee
    {
        public static void Dev ()
        {
            Developer Test = new Developer();
            Test.name = "Yaroslav";
            Test.protect = -18;
            Test.intern = -17;
            Test.protintern = -16;
            Test.privprotect = -15;
        }
    }
}

