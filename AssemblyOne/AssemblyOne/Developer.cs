using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class Developer:Employee
    {
        static void Main(string[] args)
        {
            Employee Test = new Employee();
            Test.name = "Yaroslav";
            Test.intern = -17;
            Test.protintern = -16;
            Test.protect = -19;
        }
    }
}
