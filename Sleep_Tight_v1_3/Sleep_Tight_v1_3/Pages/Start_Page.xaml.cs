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

        //FUNCTII PENTRU TIPURI DE SOMN

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

            //iara il pune la nani pt un ciclu complet
            SleepTime = new TimeSpan(15, 0, 0);
            WakeTime = WakeTime + SleepTime;
        }

        private void SegmentedSleepWithSiesta()
        {
            TimeSpan StartTime, WakeTime, SleepTime;
            //wakeup call
            StartTime = TimePickerGoSleep.Time;
            SleepTime = new TimeSpan(3, 30, 0);
            WakeTime = StartTime + SleepTime;

            //aici il pune la nani iara
            SleepTime = new TimeSpan(3, 0, 0);
            WakeTime = WakeTime + SleepTime;

            //second wakeup call
            SleepTime = new TimeSpan(2, 30, 0);
            WakeTime = WakeTime + SleepTime;

            //nani pt siesta
            SleepTime = new TimeSpan(6, 0, 0);
            WakeTime = WakeTime + SleepTime;

            //wakeup after siesta
            SleepTime = new TimeSpan(0, 18, 0);
            WakeTime = WakeTime + SleepTime;

            //il pune la nani pt un ciclu complet
            SleepTime = new TimeSpan(8, 42, 0);
            WakeTime = WakeTime + SleepTime;
        }

        private void LongSiestaSleep()
        {
            TimeSpan StartTime, WakeTime, SleepTime;
            //wakeup call
            StartTime = TimePickerGoSleep.Time;
            SleepTime = new TimeSpan(5, 0, 0);
            WakeTime = StartTime + SleepTime;

            //aici il pune la nani iara
            SleepTime = new TimeSpan(7, 0, 0);
            WakeTime = WakeTime + SleepTime;

            //second wakeup call
            SleepTime = new TimeSpan(1, 30, 0);
            WakeTime = WakeTime + SleepTime;

            //nani pt ciclu complet
            SleepTime = new TimeSpan(10, 30, 0);
            WakeTime = WakeTime + SleepTime;
        }

        private void ShortSiestaSleep()
        {
            TimeSpan StartTime, WakeTime, SleepTime;
            //wakeup call
            StartTime = TimePickerGoSleep.Time;
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

        private void TriphasicSleep()
        {
            /*1 sau 2 ore dupa rasarit
              30 de min, o ora inainte de apus
              intre 13 si 16*/
        }


    }
}