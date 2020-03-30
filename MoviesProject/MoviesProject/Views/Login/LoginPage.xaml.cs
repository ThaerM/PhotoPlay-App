using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviesProject.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            EmailEntry.Completed += (sender, e) => PasswordEntry.Focus();
            PasswordEntry.Completed += (sender, e) => LoginVM.SignInCommand.Execute(null);

        }


        private void RegisterHandler(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage() { Title = string.Empty });
        }


        private void ForgetHandler(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgetPage() { Title = string.Empty });

        }

        private async void FacebookHandler(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Facebook", "Are you sure you want to integration with facebook", "Ok", "Cancel");
            if (result)
            {
                //When Click on the OK button

            }
            else
            {
                //When Clicn on the cancel button

            }
        }

        private async void GoogleHandler(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Google", "Are you sure you want to integration with google", "Ok", "Cancel");
            if (result)
            {
                //When Click on the OK button

            }
            else
            {
                //When Clicn on the cancel button

            }
        }
    }
}