using Sleep_Tight_v1_3.Helpers;
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
    public partial class Start_Page : TabbedPage
    {
        public Start_Page ()
        {
            InitializeComponent();
        }

        

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            LocalSettings.ClearAllData();
        }
        int val = 4;
        private void ChMinute_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (ChHour.Value > 9 && ChMinute.Value > 9)
            {
                Time_Sleep.Text = Convert.ToInt32(ChHour.Value) + "." + Convert.ToInt32(ChMinute.Value);
            }
            else
            if (ChHour.Value < 9 && ChMinute.Value < 9)
            {
                Time_Sleep.Text = "0" + Convert.ToInt32(ChHour.Value) + "." + "0" + Convert.ToInt32(ChMinute.Value);
            }
            if (ChMinute.Value > 9 && ChHour.Value < 10)
            {
                Time_Sleep.Text = "0" + Convert.ToInt32(ChHour.Value) + "." + Convert.ToInt32(ChMinute.Value);
            }
            else
            {
                if (ChMinute.Value < 10 && ChHour.Value > 9)
                {
                    Time_Sleep.Text = Convert.ToInt32(ChHour.Value) + "." + "0" + Convert.ToInt32(ChMinute.Value);
                }
            }
            lemn.Text = Convert.ToInt32(ChHour.Value).ToString();
        }

        private void ChHour_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            
            if (ChHour.Value > 9 && ChMinute.Value > 9)
            {
                Time_Sleep.Text = Convert.ToInt32(ChHour.Value) + "." + Convert.ToInt32(ChMinute.Value);
            }
            else
            if(ChHour.Value < 9 && ChMinute.Value < 9)
            {
                Time_Sleep.Text ="0"+ Convert.ToInt32(ChHour.Value) + "." + "0" + Convert.ToInt32(ChMinute.Value);
            }
            if (ChMinute.Value > 9 && ChHour.Value < 10)
            {
                Time_Sleep.Text = "0" + Convert.ToInt32( ChHour.Value)+ "." + Convert.ToInt32(ChMinute.Value);
            }
            else
            {
                if (ChMinute.Value < 10 && ChHour.Value > 9)
                {
                    Time_Sleep.Text = Convert.ToInt32(ChHour.Value) + "." + "0" + Convert.ToInt32(ChMinute.Value);
                }
            }
            plm.Text = Convert.ToInt32(ChHour.Value).ToString();
        }
    }
}