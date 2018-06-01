using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sleep_Tight_v1_3.Helpers;
[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Sleep_Tight_v1_3
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage( new MainPage());
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
