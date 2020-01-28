using System;
using System.Collections.Generic;
using System.Text;

namespace Preoject_14._1
{
    public static class StringHelper
    {
        public static string CutString(this string str)
        {
            string newString = null;
            int cut = 5;
            int counter = 0;

            foreach (char item in str) 
            { 
                counter++; 
            }
            
            newString = str.Substring(2);
            return newString;
        }
    }
}
