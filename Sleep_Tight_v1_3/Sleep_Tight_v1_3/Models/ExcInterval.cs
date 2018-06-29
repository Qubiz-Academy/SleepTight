using System;
using System.Collections.Generic;
using System.Text;

namespace Sleep_Tight_v1_3.Models
{
    public class ExcInterval
    {
        public TimeSpan StartExc { get; set; }
        public TimeSpan EndExc { get; set; }

        public string IntervalString { get => StartExc.ToString() + " - " + EndExc.ToString(); }
    }
}
