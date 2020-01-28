using System;
using System.Collections.Generic;
using System.Text;

namespace HW_12
{
    class Moto : IMoto
    {
        Crud randomizer1 = new Crud();
        Random rand = new Random();

        public int ID { get; set; }
        public string manufacturer { get; set; }
        public string state { get; set; }
        public string location { get; set; }
        public int engineCapacity { get; set; }
        public double price { get; set; }

        public Moto()
        {
            
            ID = randomizer1.GetID();
            manufacturer = randomizer1.GetMark(rand.Next(1, 10));
            state = randomizer1.GetState(rand.Next(1, 5));
            location = randomizer1.GetLocation(rand.Next(1, 10));
            engineCapacity = rand.Next(400, 1200);                  Logger.Log.Debug("Set engine capacity");
            price = rand.Next(1000, 20_000);                        Logger.Log.Debug("Set price");
        }
    }
}
