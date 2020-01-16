using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;

namespace MoviesProject.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool _IsConnected;
        public bool IsConnected { get { return _IsConnected; } set { SetProperty(ref _IsConnected, value); } }

        private bool _IsShowConnectionLost;
        public bool IsShowConnectionLost { get { return _IsShowConnectionLost; } set { SetProperty(ref _IsShowConnectionLost, value); } }
        public BaseViewModel()
        {
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
            IsConnected = Connectivity.NetworkAccess == NetworkAccess.Internet;
            IsShowConnectionLost = Connectivity.NetworkAccess != NetworkAccess.Internet;
        }

        ~BaseViewModel()
        {
            Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;
        }

        void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            IsConnected = e.NetworkAccess == NetworkAccess.Internet;
            IsShowConnectionLost = e.NetworkAccess != NetworkAccess.Internet;

        }

        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;
            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
