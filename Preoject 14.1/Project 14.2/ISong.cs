using System;
using System.Collections.Generic;
using System.Text;

namespace Project_14._2
{
    interface ISong
    {
        public string songName { get; set; }
        public double songDuration { get; set; }
        public string songAuthor { get; set; }
        public int songYear { get; set; }
    }
}
