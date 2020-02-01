using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    interface IUserData
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserLocation { get; set; }
        public double UserAverageMark { get; set; }
        public string AccessLevel{ get; set; }
    }
}
