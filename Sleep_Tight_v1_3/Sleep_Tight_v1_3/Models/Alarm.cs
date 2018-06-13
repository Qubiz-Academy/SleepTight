using System;
using System.Collections.Generic;
using System.Text;

namespace Sleep_Tight_v1_3.Models
{
    public class Alarm 
    {
        public TimeSpan WakeHour
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string WakeHourString { get => WakeHour.ToString(); }
    }
}
