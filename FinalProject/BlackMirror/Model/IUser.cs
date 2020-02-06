using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackMirror.Model
{
    interface IUser
    {
        int ID { get; set; }
        int Age { get; set; }
        string UserName { get; set; }
        string UserLocation { get; set; }
        double UserAverageMark { get; set; }
        string AccessLevel { get; set; }
    }
}
