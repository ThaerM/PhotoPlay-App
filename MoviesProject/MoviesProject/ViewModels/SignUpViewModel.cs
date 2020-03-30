using MoviesProject.Models;
using MoviesProject.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoviesProject.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {
        private ServiceClient service;
        private string _FirstName;
        public string FirstName
        {
            get => _FirstName;
            set => SetProperty(ref _FirstName, value);
        }
        private string _LastName;
        public string LastName
        {
            get => _LastName;
            set => SetProperty(ref _LastName, value);
        }
        private string _Email;
        public string Email
        {
            get => _Email;
            set => SetProperty(ref _Email, value);
        }
        private string _Password;
        public string Password
        {
            get => _Password;
            set => SetProperty(ref _Password, value);
        }
        private string _ConfirmPassword;
        public string ConfirmPassword
        {
            get => _ConfirmPassword;
            set => SetProperty(ref _ConfirmPassword, value);
        }
        public ICommand SignUpCommand { get; protected set; }
        public SignUpViewModel()
        {
            SignUpCommand = new Command(OnSubmitCommand);
        }

        private async void OnSubmitCommand()
        {
            if (Password == ConfirmPassword)
            {
                service = new ServiceClient();
                var result = await service.PostAsync<UserModel>(AppConstent.POST_SignUp, new UserModel()
                {
                    email = Email,
                    first_name = FirstName,
                    last_name = LastName,
                    password = Password
                });
                if (result != null)
                {
                    await Application.Current.MainPage.DisplayAlert("", "Successful", "Ok");
                    await Application.Current.MainPage.Navigation.PopAsync();

                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("", "Falied", "Ok");

                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("", "Password not match", "Ok");
            }
        }
    }
}
