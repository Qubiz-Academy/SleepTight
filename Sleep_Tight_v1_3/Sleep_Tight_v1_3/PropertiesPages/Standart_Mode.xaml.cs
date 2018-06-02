using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sleep_Tight_v1_3.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sleep_Tight_v1_3.PropertiesPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Standart_Mode : ContentPage
	{
		public Standart_Mode ()
		{
			InitializeComponent ();
		}
        int val1 = 0;
        int val2 = 0;
        private void WantStatsYes_Clicked(object sender, EventArgs e)
        {
            if (val1 % 2 == 0)
            {
                WantStatsYes.BackgroundColor = Color.FromRgb(247, 108, 2);
                LocalSettings.ShowStats = true;
                WantStatsYes.Text = "No";
                val1++;
                AreStats.Text = "Stats are Active!";
            }
            else
            {
                val1++;
                LocalSettings.ShowStats = false;
                WantStatsYes.Text = "Yes";
                WantStatsYes.BackgroundColor = Color.FromHex("#f4db4e");
                AreStats.Text = "Stats are NOT active!";
            }
            if(val1==6)
            {
                AreStats.Text = "Please decide is not that hard!";
            }
        }

        private void WantVibration_Clicked(object sender, EventArgs e)
        {
            if (val2 % 2 == 0)
            {
                WantVibration.BackgroundColor = Color.FromRgb(247, 108, 2);
                LocalSettings.UseGyro = true;
                WantVibration.Text = "No";
                val2++;
                useGyro.Text = "Vibration features are available!";
            }
            else
            {
                val2++;
                LocalSettings.UseGyro = false;
                WantVibration.Text = "Yes";
                WantVibration.BackgroundColor = Color.FromHex("#f4db4e");
                AreStats.Text = "Vibration features are NOT available!";
            }
            if (val2 == 6)
            {
                useGyro.Text = "Please decide,seriously is not that hard!";
            }
        }

        private void ContinueToMainPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
            
            LocalSettings.ShowMainPage = 2;//Pagina 2 din catalog adica MainPage in cazul asta
            LocalSettings.ShowTypePage = false;//nu mai apare type page-ul daca e pe false
        }
    }
}