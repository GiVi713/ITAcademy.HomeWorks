using System;
using System.Collections.Generic;

namespace Project_14._3
{
    class Program
    {
        public static List<CreateNeighbor> floorNeighbors = new List<CreateNeighbor> { };

        static void Main()
        {
            RandomNeighbor.AutoCreate();
            RandomNeighbor.insertFlat();

            Console.WriteLine(floorNeighbors.Count);
        }
    }
}
