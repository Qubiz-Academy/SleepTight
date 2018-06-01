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
            Navigation.RemovePage(new GdprAccept());
        }
    }
}