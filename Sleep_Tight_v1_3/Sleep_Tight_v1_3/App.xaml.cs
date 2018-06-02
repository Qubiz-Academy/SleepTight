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

            if (LocalSettings.ShowGDPR == true)
            {
                MainPage = new NavigationPage(new GdprAccept());
            }
            else
                if (LocalSettings.ShowTypePage == true)
                {
                    MainPage = new NavigationPage(new TypeChoose1Time());
                }
                else
                {
                    MainPage = new MainPage();
                
                }

           
            
        }

		protected override void OnStart ()
		{
            // Handle when your app starts
            
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
