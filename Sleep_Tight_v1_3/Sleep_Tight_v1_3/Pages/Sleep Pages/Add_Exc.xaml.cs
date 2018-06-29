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
	public partial class Add_Exc : ContentPage
	{
		public Add_Exc ()
		{
			InitializeComponent ();
		}

        private void TimePickerStartExc_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            TimeSpan StartExc;
            StartExc = TimePickerStartExc.Time;
            App.StartExc = StartExc;
        }

        private void TimePickerEndExc_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            TimeSpan EndExc;
            EndExc = TimePickerStartExc.Time;
            App.EndExc = EndExc;
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            //se populeaza list view
            ExcList.ItemsSource = new Models.ExcInterval[] {
                new Models.ExcInterval {
                    StartExc = new TimeSpan(14, 13, 12),
                    EndExc = new TimeSpan(13, 12, 21)
                }
            };
            //se verifica daca influenteaza
            //daca se poate si inainte si dupa muta intervalul
            //se intreaba daca vrea sa fie mutat intervalul inainte sau dupa exceptie
            //se modifica variabilele
        }

        private void Rec_Clicked(object sender, EventArgs e)
        {

        }
    }
}