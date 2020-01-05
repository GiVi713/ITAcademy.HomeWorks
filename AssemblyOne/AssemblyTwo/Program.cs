using System;
using AssemblyOne;
namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Test = new Employee();
            Test.name = "Yaropolk";
        }
        class Developer : Employee
        {
            public static void Dev()
            {
                Developer Test2 = new Developer();
                Test2.name = "Yaroslav";
                Test2.protect = -18;       
                Test2.protintern = -16;
            }
        }
    }
}
