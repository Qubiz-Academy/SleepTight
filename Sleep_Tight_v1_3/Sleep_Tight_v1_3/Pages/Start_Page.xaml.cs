using Sleep_Tight_v1_3.Helpers;
using Sleep_Tight_v1_3.Models;
using Sleep_Tight_v1_3.Pages;
using Sleep_Tight_v1_3.Services;
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
        List<Alarm> alarms;
        public Start_Page()
        {
            InitializeComponent();
            if (LocalSettings.isAlarmSet == true)
                this.SelectedItem = StartMain;
            //this.listAlarmaaaa2.ItemsSource = LocalSettings.Alarms;
            alarms = LocalSettings.Alarms;
            this.listAlarmaaaa2.ItemsSource = alarms;

            this.BindingContext = this;


            var selectedId = LocalSettings.CurrentAlarm;
            listAlarmaaaa2.SelectedItem = alarms.FirstOrDefault(x => x.Id == LocalSettings.CurrentAlarm);
            StartMain.BindingContext = alarms.FirstOrDefault(x => x.Id == LocalSettings.CurrentAlarm);
            AlarmHour = alarms.FirstOrDefault(x => x.Id == LocalSettings.CurrentAlarm)?.WakeHour ?? new TimeSpan();
            AlarmName = alarms.FirstOrDefault(x => x.Id == LocalSettings.CurrentAlarm)?.Name ?? "";
        }

        public TimeSpan AlarmHour;
        public string AlarmName;


        private bool Alarma(Alarm x) { return x.Id == LocalSettings.CurrentAlarm; }

        private void ShowCurrentAlarm_Clicked(object sender, EventArgs e)
        {
            CurrentPage = StartAlarm;
        }

        private void listAlarmaaaa2_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            LocalSettings.CurrentAlarm = ((Alarm)e.SelectedItem).Id;
            StartMain.BindingContext = alarms.FirstOrDefault(x => x.Id == LocalSettings.CurrentAlarm);
            LocalSettings.isAlarmSet = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.BindingContext is Alarm al)
                Navigation.PushModalAsync(new NewAlarm1(al));


        }
        protected override void OnAppearing()
        {
            alarms = LocalSettings.Alarms;
            listAlarmaaaa2.ItemsSource = alarms;
            base.OnAppearing();



        }
        private async void NewAlarm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewAlarm1());

        }
        private TimeSpan startTime;
        private long inSTartTime;

        private int[] sleepIntervalLengths = new int[] { 8, 18, 18, 18, 8 };

        private void Start_Clicked(object sender, EventArgs e)
        {
            AlarmHour = alarms.FirstOrDefault(x => x.Id == LocalSettings.CurrentAlarm)?.WakeHour ?? new TimeSpan();

            var alarmDateTime = DateTime.Today.Add(AlarmHour);
            if (alarmDateTime <= DateTime.Now)
            {
                alarmDateTime = alarmDateTime.AddDays(1);
            }

            var alarmInMinutes = (alarmDateTime - DateTime.Now).TotalMinutes;
            var intervals = alarmInMinutes % 90;

            var alarmService = DependencyService.Get<IAlarmService>();
            alarmService.SetAlarm((int)alarmInMinutes);

            alarmSet.Text = inSTartTime.ToString();
        }
    }
}