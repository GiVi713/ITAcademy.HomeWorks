﻿using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Tom = new Employee();
            Tom.age = 19;
            Tom.name = "Tom";
            Tom.GetInfo();
        }
    }
}
