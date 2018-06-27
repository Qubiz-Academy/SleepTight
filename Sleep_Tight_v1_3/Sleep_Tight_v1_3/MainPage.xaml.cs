using Sleep_Tight_v1_3.Helpers;
using Sleep_Tight_v1_3.Pages;
using Sleep_Tight_v1_3.Pages.Sleep_Pages;
using Sleep_Tight_v1_3.PropertiesPages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sleep_Tight_v1_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
            InitializeComponent();

            if (LocalSettings.ShowGDPR)
            {
                Detail = new NavigationPage(new GdprAccept());
            }
            else if (LocalSettings.ShowTypePage)
            {
                Detail = new NavigationPage(new TypeChoose1Time());
            }
            else if (LocalSettings.ShowMainPage == 2)
                Detail = new NavigationPage(new Start_Page());
            else if (LocalSettings.ShowMainPage == 1)
                Detail = new NavigationPage(new Custom_Page());
            
            IsPresented = false;
        }

        private void Handle_Clicked_Start_Page(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Start_Page());
            IsPresented = false;
        }

        private void Handle_Clicked_Settings(object sender, EventArgs e)
        {
            //Detail = new NavigationPage(new Settings());
            Detail.Navigation.PushAsync(new Settings());
            IsPresented = false;  //Ek
        } 

        private void Handle_Clicked_Information(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new Information());
            IsPresented = false;
        }

        private void Handle_Clicked_Tips(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new Tips());
            IsPresented = false;
        }

        private void Handle_Clicked_About(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new About());
            IsPresented = false;
        }

        private void Handle_Clicked_Test(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new SegmentedSLeep());
            IsPresented = false;
        }
    }
}
