using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobilApp.ViewModel
{
    public class RegistrationVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
