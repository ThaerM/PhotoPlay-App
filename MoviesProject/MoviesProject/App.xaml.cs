using MoviesProject.Controls;
using MoviesProject.Resource;
using MoviesProject.Views.Login;
using MoviesProject.Views.Settings;
using MoviesProject.Views.TabbedView;
using Plugin.Multilingual;
using System;
using System.Diagnostics;
using System.Globalization;
using Xamarin.Forms;

namespace MoviesProject
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            try
            {
                if (Settings.Language == null) Settings.Language = "en";

                CrossMultilingual.Current.CurrentCultureInfo = new CultureInfo(Settings.Language == "ar" ? "ar" : "en");
                Device.SetFlowDirection(Settings.Language == "ar" ? FlowDirection.RightToLeft : FlowDirection.LeftToRight);
                AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;

            }
            catch (Exception ex)
            {
                Debug.WriteLine("MoviesProject.App=>" + ex.Message);
            }

            MainPage = new NavigationPage(new LoginPage());

        }

        public void ReloadApp()
        {
            CrossMultilingual.Current.CurrentCultureInfo = new CultureInfo(Settings.Language);
            Device.SetFlowDirection(Settings.Language == "ar" ? FlowDirection.RightToLeft : FlowDirection.LeftToRight);
            AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;
            Current.MainPage = new NavigationPage(new TabbedViewPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
