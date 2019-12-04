using System;




namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 1;
            Console.WriteLine(b1.GetType());
            Byte b2 = 2;
            Console.WriteLine(b2.GetType());
            sbyte s1 = 3;
            Console.WriteLine(s1.GetType());
            SByte s2 = 4;
            Console.WriteLine(s2.GetType());
            int i1 = 5;
            Console.WriteLine(i1.GetType());
            Int32 i2 = 6;
            Console.WriteLine(i2.GetType());
            double d1 = 6.5;
            Console.WriteLine(d1.GetType());
            Double d2 = 6.6;
            Console.WriteLine(d2.GetType());
            decimal dec1 = 10;
            Console.WriteLine(dec1.GetType());
            Decimal dec2 = 11;
            Console.WriteLine(dec2.GetType());
            char sym = 'x';
            Console.WriteLine(sym.GetType());
            Char sym1 = 'X';
            Console.WriteLine(sym1.GetType());
            object ob = 12;
            Console.WriteLine(ob.GetType());
            Object ob1 = 13;
            Console.WriteLine(ob1.GetType());
            string str = "Я ";
            Console.WriteLine(str.GetType());
            String str1 = "Сделаль";
            Console.WriteLine(str1.GetType());
            Console.WriteLine(str + str1);



        }
    }
}
