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
		public NewAlarm1 ()
		{
			InitializeComponent ();
		}

        private void StatsOnWake_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
    }
}