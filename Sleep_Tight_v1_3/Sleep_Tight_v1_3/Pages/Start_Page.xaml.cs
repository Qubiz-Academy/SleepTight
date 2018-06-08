using Sleep_Tight_v1_3.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sleep_Tight_v1_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start_Page : TabbedPage
    {
        public Start_Page ()
        {
            InitializeComponent();
        }

        int TotalTimeSlept = 0;
        int timeSleep;
        int timeWake;
        int mint;

        private void ChMinute_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (ChHour.Value > 9 && ChMinute.Value > 9)
            {
                Time_Sleep.Text = Convert.ToInt32(ChHour.Value) + "." + Convert.ToInt32(ChMinute.Value);
            }
            else
            if (ChHour.Value < 9 && ChMinute.Value < 9)
            {
                Time_Sleep.Text = "0" + Convert.ToInt32(ChHour.Value) + "." + "0" + Convert.ToInt32(ChMinute.Value);
            }
            if (ChMinute.Value > 9 && ChHour.Value < 10)
            {
                Time_Sleep.Text = "0" + Convert.ToInt32(ChHour.Value) + "." + Convert.ToInt32(ChMinute.Value);
            }
            else
            {
                if (ChMinute.Value < 10 && ChHour.Value > 9)
                {
                    Time_Sleep.Text = Convert.ToInt32(ChHour.Value) + "." + "0" + Convert.ToInt32(ChMinute.Value);
                }
            }
            lemn.Text = Convert.ToInt32(ChMinute.Value).ToString();
            MinuteVal.Text = Convert.ToInt32(Convert.ToInt32(ChHour.Value) * 60 + Convert.ToInt32(ChMinute.Value)).ToString();
        }

        private void ChHour_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            
            if (ChHour.Value > 9 && ChMinute.Value > 9)
            {
                Time_Sleep.Text = Convert.ToInt32(ChHour.Value) + "." + Convert.ToInt32(ChMinute.Value);
            }
            else
            if(ChHour.Value < 9 && ChMinute.Value < 9)
            {
                Time_Sleep.Text ="0"+ Convert.ToInt32(ChHour.Value) + "." + "0" + Convert.ToInt32(ChMinute.Value);
            }
            if (ChMinute.Value > 9 && ChHour.Value < 10)
            {
                Time_Sleep.Text = "0" + Convert.ToInt32( ChHour.Value)+ "." + Convert.ToInt32(ChMinute.Value);
            }
            else
            {
                if (ChMinute.Value < 10 && ChHour.Value > 9)
                {
                    Time_Sleep.Text = Convert.ToInt32(ChHour.Value) + "." + "0" + Convert.ToInt32(ChMinute.Value);
                }
            }
            plm.Text = Convert.ToInt32(ChHour.Value).ToString();
            MinuteVal.Text = Convert.ToInt32(Convert.ToInt32(ChHour.Value) * 60 + Convert.ToInt32(ChMinute.Value)).ToString();
        }

        private void ChMinuteWake_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (ChHour.Value > 9 && ChMinute.Value > 9)
            {
                Time_Wake.Text = Convert.ToInt32(ChHourWake.Value) + "." + Convert.ToInt32(ChMinuteWake.Value);
            }
            else
            if (ChHourWake.Value < 9 && ChMinuteWake.Value < 9)
            {
                Time_Wake.Text = "0" + Convert.ToInt32(ChHourWake.Value) + "." + "0" + Convert.ToInt32(ChMinuteWake.Value);
            }
            if (ChMinuteWake.Value > 9 && ChHourWake.Value < 10)
            {
                Time_Wake.Text = "0" + Convert.ToInt32(ChHourWake.Value) + "." + Convert.ToInt32(ChMinuteWake.Value);
            }
            else
            {
                if (ChMinute.Value < 10 && ChHour.Value > 9)
                {
                    Time_Wake.Text = Convert.ToInt32(ChHourWake.Value) + "." + "0" + Convert.ToInt32(ChMinuteWake.Value);
                }
            }
            lemnWake.Text = Convert.ToInt32(ChMinuteWake.Value).ToString();
            MinuteValWake.Text = Convert.ToInt32(Convert.ToInt32(ChHourWake.Value) * 60 + Convert.ToInt32(ChMinuteWake.Value)).ToString();
        }

        private void ChHourWake_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (ChHourWake.Value > 9 && ChMinuteWake.Value > 9)
            {
                Time_Wake.Text = Convert.ToInt32(ChHourWake.Value) + "." + Convert.ToInt32(ChMinuteWake.Value);
            }
            else
            if (ChHourWake.Value < 9 && ChMinuteWake.Value < 9)
            {
                Time_Wake.Text = "0" + Convert.ToInt32(ChHourWake.Value) + "." + "0" + Convert.ToInt32(ChMinuteWake.Value);
            }
            if (ChMinuteWake.Value > 9 && ChHourWake.Value < 10)
            {
                Time_Wake.Text = "0" + Convert.ToInt32(ChHourWake.Value) + "." + Convert.ToInt32(ChMinuteWake.Value);
            }
            else
            {
                if (ChMinuteWake.Value < 10 && ChHourWake.Value > 9)
                {
                    Time_Wake.Text = Convert.ToInt32(ChHourWake.Value) + "." + "0" + Convert.ToInt32(ChMinuteWake.Value);
                }
            }
            plmWake.Text = Convert.ToInt32(ChHourWake.Value).ToString();
            MinuteValWake.Text = Convert.ToInt32(Convert.ToInt32(ChHourWake.Value) * 60 + Convert.ToInt32(ChMinuteWake.Value)).ToString();
        }
        
        private void timeSlept_Clicked(object sender, EventArgs e)
        {
            timeSleep = Convert.ToInt32(MinuteVal.Text);
            timeWake = Convert.ToInt32(MinuteValWake.Text);
            TotalTimeSlept = timeWake - timeSleep;
            mint = TotalTimeSlept - Convert.ToInt32(TotalTimeSlept / 60) * 60;
            
            timeSleptVal.Text = Convert.ToInt32(TotalTimeSlept / 60).ToString() + "." + mint.ToString();
            int stop=0;
            Device.StartTimer(TimeSpan.FromSeconds(TotalTimeSlept*60), () =>
             {

                 if (stop == TotalTimeSlept * 60)
                 {
                     return false;
                 }
                 else
                 {
                     timer.Text = stop.ToString();
                     stop++;
                     return true;
                 }
                 
             });
                
        }

        private void CurentTime_Clicked(object sender, EventArgs e)
        {
            string currentTime ="";
            DateTime now = DateTime.Now.ToLocalTime();
            if (now.Hour > 9 && now.Minute > 9)
                currentTime = now.Hour.ToString() + "." + now.Minute.ToString();
            else
                if (now.Hour < 10 && now.Minute > 9)
                currentTime = "0" + now.Hour.ToString() + "." + now.Minute.ToString();
            else
                if (now.Hour > 9 && now.Minute < 10)
                currentTime = now.Hour.ToString() + "." + "0" + now.Minute.ToString();
            else
                if (now.Hour < 10 && now.Minute < 10)
                currentTime = "0"+now.Hour.ToString() + "." + "0" + now.Minute.ToString();
            Time_Sleep.Text = currentTime;
            MinuteVal.Text = Convert.ToInt32(now.Hour * 60 + now.Minute).ToString();
            
        }
    }
}