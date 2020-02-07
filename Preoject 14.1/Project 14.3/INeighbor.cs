using System;
using System.Collections.Generic;
using System.Text;

namespace Project_14._3
{
    interface INeighbor
    {
        public string FullName { get; set; }
        public int floor { get; set; }
        public int PhoneNumber { get; set; }
        public int flatNumber { get; set; }
    }
}
