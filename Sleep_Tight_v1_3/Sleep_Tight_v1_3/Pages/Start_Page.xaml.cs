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
            test.Text = "Current Start Time is " + LocalSettings.lastTimeSet.ToString();
        }
        
        private void TimePickerGoSleep_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            
            
        }
        int minutes_slept = 0;
        
        private void PickCurrentTime_Clicked(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now.ToLocalTime();
            TimePickerGoSleep.Time = now.TimeOfDay;
            LocalSettings.lastTimeSet = TimePickerGoSleep.Time.ToString();
            test.Text = "Current Start Time is " + LocalSettings.lastTimeSet.ToString();
        }

        private void saveSetTime_Clicked(object sender, EventArgs e)
        {
            LocalSettings.lastTimeSet = TimePickerGoSleep.Time.ToString();
            test.IsVisible = false;
        }
    }
}