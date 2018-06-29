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
    public partial class SegmentedSLeep : TabbedPage
    {
        public SegmentedSLeep ()
        {
            InitializeComponent();
        }

        private void Button_Clicked_PickCurrentTime(object sender, EventArgs e)
        {
            TimeSpan StartTime, WakeTime, SleepTime;
            var nowTime = DateTime.Now;
            //afisare timp luat
            //this.PickedTime.Text = Convert.ToString(nowTime.Hour);
            //wakeup call
            StartTime = new TimeSpan(nowTime.Hour,nowTime.Minute,nowTime.Second);
            SleepTime = new TimeSpan(3, 30, 0);
            WakeTime = StartTime + SleepTime;
            if(StartTime.Minutes>9 && WakeTime.Minutes>9)
                this.CoreSleep1.Text = Convert.ToString(StartTime.Hours) + ":" + Convert.ToString(StartTime.Minutes) + " to " + Convert.ToString(WakeTime.Hours) + ":" + Convert.ToString(WakeTime.Minutes);
            else
                this.CoreSleep1.Text = Convert.ToString(StartTime.Hours) + ":0" + Convert.ToString(StartTime.Minutes) + " to " + Convert.ToString(WakeTime.Hours) + ":0" + Convert.ToString(WakeTime.Minutes);

            //aici il pune la nani iara
            SleepTime = new TimeSpan(2, 0, 0);
            WakeTime = WakeTime + SleepTime;
           

            //second wakeup call
            SleepTime = new TimeSpan(3, 30, 0);
            if(WakeTime.Minutes>9)
                 this.CoreSleep2.Text = Convert.ToString(WakeTime.Hours) + ":" + Convert.ToString(WakeTime.Minutes) + " to ";
            else
                this.CoreSleep2.Text = Convert.ToString(WakeTime.Hours) + ":0" + Convert.ToString(WakeTime.Minutes) + " to ";

            WakeTime = WakeTime + SleepTime;

            if(WakeTime.Minutes>9)
                this.CoreSleep2.Text = this.CoreSleep2.Text + Convert.ToString(WakeTime.Hours) + ":" + Convert.ToString(WakeTime.Minutes);
            else
                this.CoreSleep2.Text = this.CoreSleep2.Text + Convert.ToString(WakeTime.Hours) + ":0" + Convert.ToString(WakeTime.Minutes);

            //iara il pune la nani pt un ciclu complet
            SleepTime = new TimeSpan(15, 0, 0);
            WakeTime = WakeTime + SleepTime;
        }

        private void Button_Clicked_Add(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Add_Exc());
        }
    }
}