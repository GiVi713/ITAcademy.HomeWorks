using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackMirror.Model
{
    class User : IUser
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string UserLocation { get; set; }
        public double UserAverageMark { get; set; }
        public string AccessLevel { get; set; }

    }
    class NewUser
    {
        
    }
}
