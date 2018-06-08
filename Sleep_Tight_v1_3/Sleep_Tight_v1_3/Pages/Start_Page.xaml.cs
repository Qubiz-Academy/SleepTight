﻿using Sleep_Tight_v1_3.Helpers;
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

        private void TimePickerGoSleep_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            test.Text = TimePickerGoSleep.Time.Hours.ToString();
        }

        private void SegmentedSleep()
        {
            TimeSpan StartTime, WakeTime, SleepTime;
            //wakeup call
            StartTime = TimePickerGoSleep.Time;
            SleepTime = new TimeSpan(3, 30, 0);
            WakeTime = StartTime + SleepTime;
            
            //aici il pune la nani iara
            SleepTime = new TimeSpan(2, 0, 0);
            WakeTime = WakeTime + SleepTime;

            //second wakeup call
            SleepTime = new TimeSpan(3, 30, 0);
            WakeTime = WakeTime + SleepTime;
        }
    }
}