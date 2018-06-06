using Sleep_Tight_v1_3.Helpers;
using Sleep_Tight_v1_3.PropertiesPages;
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
	public partial class GdprAccept : ContentPage
	{
		public GdprAccept ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (LocalSettings.ShowTypePage == true)
            {

                Navigation.PushModalAsync(new TypeChoose1Time());
                
            }
            else
            {
                Navigation.PushModalAsync(new MainPage());
            }
            LocalSettings.ShowGDPR = false;
            

            

        }
    }
}