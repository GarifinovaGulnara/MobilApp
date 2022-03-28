using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using MobilApp.View;
using System.Windows.Input;

namespace MobilApp.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand RegistCommand { protected set; get; }
        public ICommand LogInCommand { protected set; get; }
        public INavigation Navigation { get; set; }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public MainVM()
        {
            RegistCommand = new Command(Regist);
            LogInCommand = new Command(LogIn);
        }
        private void Regist()
        {
            Navigation.PushAsync(new RegistrationPage());
        }

        private void LogIn()
        {
            Navigation.PushAsync(new ChooseProject());
        }
    }


}

