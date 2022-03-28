using System;
using System.Collections.Generic;
using System.Text;
using MobilApp.View;
using MobilApp.Model;
using System.Windows.Input;
using MobilApp.db;
using System.ComponentModel;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace MobilApp.ViewModel
{
    
    public class InfoProjVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<ProjectModel> Projects { get; set; }
        public INavigation Navigation { get; set; }
        ChooseProjVM selectedProj;
        public InfoProjVM()
        {
            Projects = new ObservableCollection<ProjectModel>();
            
        }
        
        public ChooseProjVM ListVM { get { return selectedProj; } 
        set
            {
                if (selectedProj != value)
                {
                    selectedProj = value;
                    OnPropertyChanged("ListVM");
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
    
}
