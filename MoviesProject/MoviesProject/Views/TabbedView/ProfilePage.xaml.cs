using MoviesProject.Views.Login;
using MoviesProject.Views.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviesProject.Views.TabbedView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {

        public List<ListViewPage> listViewPages;
        public class ListViewPage
        {
            public int Id { get; set; }
            public string NamePage { get; set; }
            public string ImagePage { get; set; }
            public Type TargetType { get; set; }
        }
        public ProfilePage()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            listViewPages = new List<ListViewPage>()
            {
                new ListViewPage(){Id=1,NamePage="Account" , ImagePage="ic_profileSmall",TargetType= typeof( AccountPage )  },
                new ListViewPage(){Id=1,NamePage="Notification" , ImagePage="ic_notification",TargetType=typeof(  NotificationPage)   },
                new ListViewPage(){Id=3,NamePage="Settings" , ImagePage="ic_settings" ,TargetType=typeof(ThemeSelectionPage)},
                new ListViewPage(){Id=4,NamePage="Help" , ImagePage="ic_help"  ,TargetType=null},
                new ListViewPage(){Id=5,NamePage="Logout" , ImagePage="ic_logout",TargetType=null }
            };

            ImageListView.ItemsSource = listViewPages;
        }

        private async void SelectHandler(object sender, SelectionChangedEventArgs e)
        {
            var result = e.CurrentSelection.FirstOrDefault() as ListViewPage;
            if (result != null)
            {
                if (result.Id == 4)
                {
                    await Xamarin.Essentials.Browser.OpenAsync("https://github.com/ThaerM/PhotoPlay-App");
                }
                else if (result.Id == 5)
                {
                    var response = await DisplayAlert("", "Are You sure you want logout?", "Yes", "No");
                    if (response)
                    {
                        Application.Current.MainPage = new NavigationPage(new LoginPage());
                    }
                }
                else
                {
                    await Navigation.PushAsync((Page)Activator.CreateInstance(result.TargetType));
                }
            }
            ((CollectionView)sender).SelectedItem = null;
        }
    }


}