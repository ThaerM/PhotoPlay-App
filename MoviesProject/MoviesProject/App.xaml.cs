using MoviesProject.Views.Login;
using Xamarin.Forms;

namespace MoviesProject
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();

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
