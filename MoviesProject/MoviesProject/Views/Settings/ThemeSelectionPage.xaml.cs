using MoviesProject.ThemeResources;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviesProject.Views.Settings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemeSelectionPage : ContentPage
    {
        public ThemeSelectionPage()
        {
            InitializeComponent();
        }

        private void OnPickerSelectionChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            string theme = (string)picker.SelectedItem;

            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                switch (theme)
                {
                    case "Light":
                        mergedDictionaries.Add(new LightTheme());
                        break;
                    case "Dark":
                        mergedDictionaries.Add(new DarkTheme());
                        break;
                    default:
                        mergedDictionaries.Add(new DarkTheme());
                        break;
                }
                StatusLabel.Text = $"{theme.ToString()} theme loaded. Close this page.";

            }
        }

        public async Task Dismiss()
        {
            await Navigation.PopModalAsync( );
        }
    }
}