using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sleep_Tight_v1_3.PropertiesPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TypeChoose1Time : ContentPage
	{
		public TypeChoose1Time ()
		{
			InitializeComponent ();
		}

        private void Custom_Clicked(object sender, EventArgs e)
        {
            
        }

        private void PolyFazic_Clicked(object sender, EventArgs e)
        {

        }

        private void Standard_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Standart_Mode());
            
        }
    }
}