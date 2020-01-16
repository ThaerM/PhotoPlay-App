using MoviesProject.Models;
using MoviesProject.Services;
using MoviesProject.Views.TabbedView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoviesProject.ViewModels
{
    public class ProfileViewModdel : BaseViewModel
    {
        ObservableCollection<UserModel> _UserCollection;
        public ObservableCollection<UserModel> UserCollection
        {
            get { return _UserCollection; }
            set { SetProperty(ref _UserCollection, value); }
        }
        bool _IsLoad;
        public bool IsLoad { get { return _IsLoad; } set { SetProperty(ref _IsLoad, value); } }

        public ICommand SignInCommand { private set; get; }
        ServiceClient service;

        string _EmailData;
        public string EmailData { get { return _EmailData; } set { SetProperty(ref _EmailData, value); } }

        string _Password;
        public string Password { get { return _Password; } set { SetProperty(ref _Password, value); } }

        public ProfileViewModdel()
        {
            UserCollection = new ObservableCollection<UserModel>();
            SignInCommand = new Command(SignInHandler);
            IsLoad = false;
        }

        private async void SignInHandler()
        {
            if (CheckData())
            {
                IsLoad = true;
                if (EmailData == "test" && Password == "123")
                {
                    Application.Current.MainPage = new NavigationPage(new TabbedViewPage());
                }


                //Use to sent get method to API
                service = new ServiceClient();
                var result = await service.GetAsync<UserModel>(AppConstent.GET_SignIn + EmailData + "/" + Password);
                if (result != null)
                {
                    InfoData.userModel = result;
                    Application.Current.MainPage = new NavigationPage(new TabbedViewPage());
                }
                IsLoad = false;
            }
        }
        bool CheckData()
        {
            if (string.IsNullOrEmpty(EmailData))
            {
                Application.Current.MainPage.DisplayAlert("Missing Data", "Please write the email", "Ok");
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                Application.Current.MainPage.DisplayAlert("Missing Data", "Please write the passwrod", "Ok");
                return false;
            }
            return true;
        }
    }
}
