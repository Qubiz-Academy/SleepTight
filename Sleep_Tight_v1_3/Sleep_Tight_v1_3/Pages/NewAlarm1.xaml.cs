using Sleep_Tight_v1_3.Helpers;
using Sleep_Tight_v1_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sleep_Tight_v1_3.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewAlarm1 : ContentPage
    {
        public NewAlarm1()
        {
            InitializeComponent();
            al = new Alarm();
            BindingContext = al;
        }
        public NewAlarm1(Alarm alarm) : this()
        {
            al = alarm;
            BindingContext = al;
        }
        Alarm al;
        private void StatsOnWake_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }

        private void setAlarm_Clicked(object sender, EventArgs e)
        {
            var alarms = LocalSettings.Alarms;

            if (al.Id == 0)
            {
                al.Id = (alarms.LastOrDefault()?.Id ?? 0) +1;
                alarms.Add(al);
            }
            else
            {
                for (int i = 0; i < alarms.Count; i++)
                {
                    if (alarms[i].Id == al.Id)
                    {
                        alarms[i] = al;
                    }
                }
            }
            
            LocalSettings.Alarms = alarms;
            Navigation.PopModalAsync();
            LocalSettings.isAlarmSet = true;
        }

        private void cancelAlarm_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}