using Sleep_Tight_v1_3.Helpers;
using Sleep_Tight_v1_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sleep_Tight_v1_3
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start_Page : TabbedPage
    {
        
        public Start_Page ()
        {
            InitializeComponent();
            //this.listAlarmaaaa2.ItemsSource = LocalSettings.Alarms;
            this.listAlarmaaaa2.ItemsSource = new Alarm[] { new Alarm {Name = "1" , WakeHour=new TimeSpan (0,0,0,0)} };
            
            if (LocalSettings.isAlarmSet == false)
            {
                alarmSet.Text = "There is no alarm set yet! " +
                    "Press above to set one!";
                CurrentPage = StartAlarm;
            }
            else
            {
                CurrentPage = StartMain;
                alarmSet.IsVisible = false;
            }
        }

        private void ShowCurrentAlarm_Clicked(object sender, EventArgs e)
        {
            CurrentPage = StartAlarm;
        }

        private void listAlarmaaaa2_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}