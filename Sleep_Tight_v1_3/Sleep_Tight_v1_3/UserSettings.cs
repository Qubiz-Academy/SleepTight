﻿// Helpers/Settings.cs  
using Plugin.Settings;
using Plugin.Settings.Abstractions;

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

        public static string Setting1
        {
            get => AppSettings.GetValueOrDefault(nameof(Setting1), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Setting1), value);
        }

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
        //etermina daca utilizatorul vrea sa ii fie inregistrate miscarile noapte 
        public static void ClearAllData()
        {
            AppSettings.Clear();
        }

    }
}