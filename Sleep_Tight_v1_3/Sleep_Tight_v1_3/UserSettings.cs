// Helpers/Settings.cs  
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using Plugin.Settings.Abstractions.Extensions;
using System;

namespace Sleep_Tight_v1_3.Helpers
{
    /// <summary>  
    /// This is the Settings static class that can be used in your Core solution or in any  
    /// of your client applications. All settings are laid out the same exact way with getters  
    /// and setters.   
    /// </summary>  
    public static class LocalSettings
    {
        static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }


        //Specific fontcolors
        public static string FontColorBack
        {
            get => AppSettings.GetValueOrDefault(nameof(FontColorBack), "#042044");
            set => AppSettings.AddOrUpdateValue(nameof(FontColorBack), value);
        }
        public static string FontColorText
        {
            get => AppSettings.GetValueOrDefault(nameof(FontColorText), "#cee3ff");
            set => AppSettings.AddOrUpdateValue(nameof(FontColorText), value);
        }
        public static string FontButtonBack
        {
            get => AppSettings.GetValueOrDefault(nameof(FontButtonBack), "#164b8e");
            set => AppSettings.AddOrUpdateValue(nameof(FontButtonBack), value);
        }
        public static string FontTextButton
        {
            get => AppSettings.GetValueOrDefault(nameof(FontTextButton), "#cee3ff");
            set => AppSettings.AddOrUpdateValue(nameof(FontTextButton), value);
        }
        //


        public static bool ShowGDPR
        {
            get => AppSettings.GetValueOrDefault(nameof(ShowGDPR), true);
            set => AppSettings.AddOrUpdateValue(nameof(ShowGDPR), value);
        }
        //determina daca apare sau nu pagina de alegeri de tipuri de somn
        public static bool ShowTypePage
        {
            get => AppSettings.GetValueOrDefault(nameof(ShowTypePage), true);
            set => AppSettings.AddOrUpdateValue(nameof(ShowTypePage), value);
        }
        public static int ShowMainPage
        {
            get => AppSettings.GetValueOrDefault(nameof(ShowMainPage), 2);
            set => AppSettings.AddOrUpdateValue(nameof(ShowMainPage), value);
        }
        //determina care pagina principala apare la start
        public static bool ShowStats
        {
            get => AppSettings.GetValueOrDefault(nameof(ShowStats), false);
            set => AppSettings.AddOrUpdateValue(nameof(ShowStats), value);
        }
        //determina daca utilizatorul va vrea sau nu stats dimineata
        public static bool UseGyro
        {
            get => AppSettings.GetValueOrDefault(nameof(UseGyro), false);
            set => AppSettings.AddOrUpdateValue(nameof(UseGyro), value);
        }
        //determina daca utilizatorul vrea sa ii fie inregistrate miscarile noapte 
        public static string lastTimeSet
        {
            get => AppSettings.GetValueOrDefault(nameof(lastTimeSet), "");
            set => AppSettings.AddOrUpdateValue(nameof(lastTimeSet), value);
        }


        //is an alarm set or not
        public static bool isAlarmSet
        {
            get => AppSettings.GetValueOrDefault(nameof(isAlarmSet), false);
            set => AppSettings.AddOrUpdateValue(nameof(isAlarmSet), value);
        }

        public static void ClearAllData()
        {
            AppSettings.Clear();
        }

    }
}