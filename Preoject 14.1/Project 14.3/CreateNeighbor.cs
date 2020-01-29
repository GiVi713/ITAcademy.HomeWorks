using System;
using System.Collections.Generic;
using System.Text;

namespace Project_14._3
{
    class CreateNeighbor
    {
        Randomizer randomizer1 = new Randomizer();
        Random rand = new Random();

        public string FullName { get; set; }
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
