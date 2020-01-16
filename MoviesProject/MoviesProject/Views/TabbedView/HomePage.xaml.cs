using MoviesProject.Models;
using MoviesProject.ViewModels;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviesProject.Views.TabbedView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var result = (MoviesComingSoonDB)e.CurrentSelection.FirstOrDefault();
            if (result != null)
            {
                MoviesViewModel.SelectionItem(result);
            }
        }
    }
}