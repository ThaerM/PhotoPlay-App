using Plugin.Settings;
using Plugin.Settings.Abstractions;
namespace MoviesProject.Controls
{
    /// <summary>
    /// This is the settings static class that can be used in your core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters.
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Settings Constants
        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        public static string UserName
        {
            get => AppSettings.GetValueOrDefault(nameof(UserName), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(UserName), value);
        }

        public static string Password
        {
            get => AppSettings.GetValueOrDefault(nameof(Password), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Password), value);
        }

        public static string Language
        {
            get => AppSettings.GetValueOrDefault(nameof(Language), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Language), value);

        }

        #endregion

        public static void ClearAllData()
        {
            AppSettings.Clear();
        }

        public static string GeneralSettings
        {
            get => AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            set => AppSettings.AddOrUpdateValue(SettingsKey, value);
        }
    }
}
