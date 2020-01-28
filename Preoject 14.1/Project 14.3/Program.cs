using System;
using System.Collections.Generic;

namespace Project_14._3
{
    class Program
    {
        public static List<Neighbor> floorNeighbors = new List<Neighbor> { };

        static void Main(string[] args)
        {
        }

    class Neighbor
    {
        Randomizer randomizer1 = new Randomizer();
        Random rand = new Random();

        public int ID { get; set; }
        public string FullName { get; set; }
        public string state { get; set; }
        public string location { get; set; }
        public int PhoneNumber { get; set; }
        public double flatNumber { get; set; }

        public Neighbor()
        {
            FullName = randomizer1.GetName(rand.Next(1, 10));
            location = randomizer1.GetLocation(rand.Next(1, 10));
            PhoneNumber = rand.Next(400, 1200);               
            flatNumber = rand.Next(1, 30);                        
        }
    }
    }
}
