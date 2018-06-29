using System;
using System.Collections.Generic;
using System.Text;

namespace Sleep_Tight_v1_3.Services
{
    public interface IAlarmService
    {
        void SetAlarm(int ringAfterMinutes);
    }
}
