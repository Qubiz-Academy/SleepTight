using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sleep_Tight_v1_3.Helpers;
using Sleep_Tight_v1_3.PropertiesPages;
using Sleep_Tight_v1_3.Pages;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Sleep_Tight_v1_3
{
	public partial class App : Application
	{
		public App ()
		{
            
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

           
            
        }

		protected override void OnStart ()
		{
            // Handle when your app starts
            App.Current.Resources["backgroundColor"] = Color.FromHex(LocalSettings.FontColorBack);
            App.Current.Resources["textColor"] = Color.FromHex(LocalSettings.FontColorText);
            App.Current.Resources["buttonBackColor"] = Color.FromHex(LocalSettings.FontButtonBack);
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
