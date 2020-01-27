using System;
using System.Collections.Generic;
using System.Text;

namespace HW_12 
{
    interface IMoto
    {
        public int ID { get; set; }
        public string manufacturer { get; set; }
        public string state { get; set; }
        public string location { get; set; }
        public int engineCapacity { get; set; }
        public double price { get; set; }
    }
}
