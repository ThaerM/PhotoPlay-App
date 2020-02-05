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
            public string NamePage { get; set; }
            public string ImagePage { get; set; }
        }
        public ProfilePage()
        {
            InitializeComponent();
            listViewPages = new List<ListViewPage>()
            {
                new ListViewPage(){NamePage="Account" , ImagePage="ic_profileSmall" },
                new ListViewPage(){NamePage="Notification" , ImagePage="ic_notification" },
                new ListViewPage(){NamePage="Settings" , ImagePage="ic_settings" },
                new ListViewPage(){NamePage="Help" , ImagePage="ic_help" },
                new ListViewPage(){NamePage="Logout" , ImagePage="ic_logout" }
            };

            ImageListView.ItemsSource = listViewPages;
        }
    }


}