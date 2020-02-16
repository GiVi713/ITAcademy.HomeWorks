using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BlackMirror.Model
{
    public class CheckText
    {
        public bool CheckName (string text)
        {
            string toReturn;
            do
            {
                Console.Write($"input {text}:");
            } while (!Regex.IsMatch(toReturn = Console.ReadLine(), @"^[A-Za-z]+$"));
            return true;
        }
    }
}
