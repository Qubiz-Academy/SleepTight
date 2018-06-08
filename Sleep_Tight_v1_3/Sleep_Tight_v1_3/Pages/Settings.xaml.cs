using Sleep_Tight_v1_3.Helpers;
using Sleep_Tight_v1_3.Pages;
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
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();
		}

        private void ClearData_Clicked(object sender, EventArgs e)
        {
            LocalSettings.ClearAllData();
            
        }

        private void ChangeColourSet_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ColourSet());
        }
    }
}