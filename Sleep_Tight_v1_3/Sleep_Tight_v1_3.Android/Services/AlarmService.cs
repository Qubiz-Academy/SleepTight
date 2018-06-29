using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Sleep_Tight_v1_3.Droid.Services;
using Sleep_Tight_v1_3.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(AlarmService))]
namespace Sleep_Tight_v1_3.Droid.Services
{
    public class AlarmService : IAlarmService
    {
        public void SetAlarm(int ringAfterMinutes)
        {
            //Intent i = new Intent(Forms.Context, typeof(BroadcastReceiver));
            Intent i = new Intent(Forms.Context, typeof(MainActivity));
            i.PutExtra("alarm", "asdfadfadf");

            //PASS CONTEXT,YOUR PRIVATE REQUEST CODE,INTENT OBJECT AND FLAG
            //PendingIntent pi = PendingIntent.GetBroadcast(Forms.Context, 0, i, 0);
            PendingIntent pi = PendingIntent.GetActivity(Forms.Context, 0, i, 0);

            //INITIALIZE ALARM MANAGER
            Android.App.AlarmManager alarmManager = (Android.App.AlarmManager)Forms.Context.GetSystemService(Context.AlarmService);

            //SET THE ALARM
            alarmManager.Set(AlarmType.RtcWakeup, JavaSystem.CurrentTimeMillis() + (ringAfterMinutes * 60 * 1000), pi);
            Toast.MakeText(Forms.Context, "Alarm set in: " + ringAfterMinutes + " minutes", ToastLength.Short).Show();

        }
    }
}