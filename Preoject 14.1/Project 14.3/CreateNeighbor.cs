using System;
using System.Collections.Generic;
using System.Text;

namespace Project_14._3
{
    class CreateNeighbor : INeighbor
    {
        Randomizer randomizer1 = new Randomizer();
        Random rand = new Random();

        public string FullName { get; set; }
        public int floor { get; set; }
        public int PhoneNumber { get; set; }
        public int flatNumber { get; set; }

        public CreateNeighbor()
        {
            FullName = randomizer1.GetName(rand.Next(1, 10));
            floor = randomizer1.GetFloor();
            PhoneNumber = randomizer1.PhoneNumber(rand.Next(1,10));
            flatNumber = randomizer1.GetFlat();
        }
    }
}

