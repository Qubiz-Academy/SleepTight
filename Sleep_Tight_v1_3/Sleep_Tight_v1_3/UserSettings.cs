// Helpers/Settings.cs  
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

        public static string ShowLogin
        {
            get => AppSettings.GetValueOrDefault(nameof(ShowLogin), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(ShowLogin), value);
        }

        public static void ClearAllData()
        {
            AppSettings.Clear();
        }

    }
}