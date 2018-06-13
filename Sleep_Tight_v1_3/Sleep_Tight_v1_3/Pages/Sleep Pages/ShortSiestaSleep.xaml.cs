using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sleep_Tight_v1_3.Pages.Sleep_Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShortSiestaSleep : TabbedPage
    {
        public ShortSiestaSleep ()
        {
            InitializeComponent();
        }

        private void Button_Clicked_PickCurrentTime(object sender, EventArgs e)
        {
            TimeSpan StartTime, WakeTime, SleepTime;
            var nowTime = DateTime.Now;
            //afisare timp luat
            this.PickedTime.Text = Convert.ToString(nowTime.Hour);
            //wakeup call
            StartTime = new TimeSpan(nowTime.Hour, nowTime.Minute, nowTime.Second);
            SleepTime = new TimeSpan(6, 0, 0);
            WakeTime = StartTime + SleepTime;

            //aici il pune la nani iara
            SleepTime = new TimeSpan(7, 0, 0);
            WakeTime = WakeTime + SleepTime;

            //second wakeup call
            SleepTime = new TimeSpan(0, 18, 0);
            WakeTime = WakeTime + SleepTime;

            //nani pt ciclu complet
            SleepTime = new TimeSpan(10, 42, 0);
            WakeTime = WakeTime + SleepTime;
        }
    }
}