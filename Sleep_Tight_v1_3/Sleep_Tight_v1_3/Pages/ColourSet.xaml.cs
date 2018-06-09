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
            LocalSettings.FontButtonBack = "#1E88E5";
            LocalSettings.FontColorBack = "#0D47A1";
            LocalSettings.FontColorText = "#E3F2FD";
            LocalSettings.FontTextButton = "#E3F2FD";

            App.Current.Resources["backgroundColor"] = Color.FromHex(LocalSettings.FontColorBack);
            App.Current.Resources["textColor"] = Color.FromHex(LocalSettings.FontColorText);
            App.Current.Resources["buttonBackColor"] = Color.FromHex(LocalSettings.FontButtonBack);
            App.Current.Resources["textButtonColor"] = Color.FromHex(LocalSettings.FontTextButton);
        }

        private void pickerBlack_Clicked(object sender, EventArgs e)
        {
            LocalSettings.FontButtonBack = "#616161";
            LocalSettings.FontColorBack = "#E0E0E0";
            LocalSettings.FontColorText = "#212121";
            LocalSettings.FontTextButton = "#EEEEEE";

            App.Current.Resources["backgroundColor"] = Color.FromHex(LocalSettings.FontColorBack);
            App.Current.Resources["textColor"] = Color.FromHex(LocalSettings.FontColorText);
            App.Current.Resources["buttonBackColor"] = Color.FromHex(LocalSettings.FontButtonBack);
            App.Current.Resources["textButtonColor"] = Color.FromHex(LocalSettings.FontTextButton);
        }

        private void pickerDarkTile_Clicked(object sender, EventArgs e)
        {
            LocalSettings.FontButtonBack = "#4DB6AC";
            LocalSettings.FontColorBack = "#004D40";
            LocalSettings.FontColorText = "#E0F2F1";
            LocalSettings.FontTextButton = "#E0F2F1";

            App.Current.Resources["backgroundColor"] = Color.FromHex(LocalSettings.FontColorBack);
            App.Current.Resources["textColor"] = Color.FromHex(LocalSettings.FontColorText);
            App.Current.Resources["buttonBackColor"] = Color.FromHex(LocalSettings.FontButtonBack);
            App.Current.Resources["textButtonColor"] = Color.FromHex(LocalSettings.FontTextButton);
        }

        private void pickerGrayScale_Clicked(object sender, EventArgs e)
        {
            LocalSettings.FontButtonBack = "#607D8B";
            LocalSettings.FontColorBack = "#37474F";
            LocalSettings.FontColorText = "#ECEFF1";
            LocalSettings.FontTextButton = "#ECEFF1";

            App.Current.Resources["backgroundColor"] = Color.FromHex(LocalSettings.FontColorBack);
            App.Current.Resources["textColor"] = Color.FromHex(LocalSettings.FontColorText);
            App.Current.Resources["buttonBackColor"] = Color.FromHex(LocalSettings.FontButtonBack);
            App.Current.Resources["textButtonColor"] = Color.FromHex(LocalSettings.FontTextButton);
        }
    }
}