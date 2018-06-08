using Sleep_Tight_v1_3.Helpers;
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
	public partial class ColourSet : ContentPage
	{
		public ColourSet ()
		{
			InitializeComponent ();
		}

        private void pickerBlue_Clicked(object sender, EventArgs e)
        {
            LocalSettings.FontButtonBack = "#164b8e";
            LocalSettings.FontColorBack = "#042044";
            LocalSettings.FontColorText = "#cee3ff";
            LocalSettings.FontTextButton = "#cee3ff";

            App.Current.Resources["backgroundColor"] = Color.FromHex(LocalSettings.FontColorBack);
            App.Current.Resources["textColor"] = Color.FromHex(LocalSettings.FontColorText);
            App.Current.Resources["buttonBackColor"] = Color.FromHex(LocalSettings.FontButtonBack);
            
        }

        private void pickerBlack_Clicked(object sender, EventArgs e)
        {
            LocalSettings.FontButtonBack = "#f4f4f4";
            LocalSettings.FontColorBack = "#141313";
            LocalSettings.FontColorText = "#fcfdff";
            LocalSettings.FontTextButton = "#000000";

            App.Current.Resources["backgroundColor"] = Color.FromHex(LocalSettings.FontColorBack);
            App.Current.Resources["textColor"] = Color.FromHex(LocalSettings.FontColorText);
            App.Current.Resources["buttonBackColor"] = Color.FromHex(LocalSettings.FontButtonBack);
        }

        private void pickerDarkViolet_Clicked(object sender, EventArgs e)
        {
            LocalSettings.FontButtonBack = "#036772";
            LocalSettings.FontColorBack = "#073544";
            LocalSettings.FontColorText = "#0d1314";
            LocalSettings.FontTextButton = "#0d1314";

            App.Current.Resources["backgroundColor"] = Color.FromHex(LocalSettings.FontColorBack);
            App.Current.Resources["textColor"] = Color.FromHex(LocalSettings.FontColorText);
            App.Current.Resources["buttonBackColor"] = Color.FromHex(LocalSettings.FontButtonBack);
        }

    }
}