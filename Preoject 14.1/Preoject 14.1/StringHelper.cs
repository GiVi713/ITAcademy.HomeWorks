using System;
using System.Collections.Generic;
using System.Text;

namespace Preoject_14._1
{
    public static class StringHelper
    {
        public static string CutString(this string str)
        {
            string newString = str.Remove(5, str.Length-5 );
            return newString;
        }
    }
}
