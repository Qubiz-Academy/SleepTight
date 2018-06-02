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

        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            LocalSettings.ShowGDPR = false ;
            await Navigation.PopModalAsync();
            
            if (LocalSettings.ShowTypePage == false)
            {
               
                await Navigation.PushModalAsync(new TypeChoose1Time());
                Navigation.RemovePage(new GdprAccept());
            }
            Navigation.RemovePage(new GdprAccept());
        }
    }
}