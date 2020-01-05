using System;
using System.Text;

namespace HW08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sym = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?");
            for (int i = 0; i < sym.Length ; i++)
            {
                if (sym[i] == '!')
                {
                    sym.Remove(i, 1);
                    i--;
                }           
                if (sym[i] == '?')
                {
                    sym.Replace(' ', '_', i, sym.Length - i);
                    break;
                }
            }  
        }
    }
}
