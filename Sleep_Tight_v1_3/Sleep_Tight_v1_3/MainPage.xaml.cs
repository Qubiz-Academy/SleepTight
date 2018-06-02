﻿using Sleep_Tight_v1_3.Helpers;
using Sleep_Tight_v1_3.Pages;
using Sleep_Tight_v1_3.PropertiesPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(LocalSettings.ShowMainPage==2)
                Detail = new NavigationPage( new Start_Page());//start_page pagina principala pt standart o sa facem altele pt custom si plyfazic si plm
            else
            {

            }
        }

        private void Handle_Clicked_Start_Page(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Start_Page());
            IsPresented = false;
        }

        private void Handle_Clicked_Settings(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Settings());
            IsPresented = false;  //Ek
        } 

        private void Handle_Clicked_Information(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Information());
            IsPresented = false;
        }

        private void Handle_Clicked_Tips(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Tips());
            IsPresented = false;
        }

        private void Handle_Clicked_About(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new About());
            IsPresented = false;
        }
    }
}
