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
        public INavigation Navigation { get; set; }
        public ICommand UpdateCommand { protected set; get; }
        ChooseProjVM selectedProj;
        public ProjectModel Project { get; set; }
        
        public InfoProjVM()
        {
            Project = new ProjectModel();
            UpdateCommand = new Command(UpdateBtn);
        }

        public string Name { get => Project.Name; set { Project.Name = value; OnPropertyChanged("Name"); } }
        public string Description { get => Project.Description; set { Project.Description = value; OnPropertyChanged("Description"); } }
        public string PhoneNum { get => Project.PhoneNum; set { Project.PhoneNum = value; OnPropertyChanged("PhoneNum"); } }
        public string Email { get => Project.Email; set { Project.Email = value; OnPropertyChanged("Email"); } }
        public string Adress { get => Project.Adress; set { Project.Adress = value; OnPropertyChanged("Adress"); } }
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

        private async void UpdateBtn()
        {
            await Navigation.PushAsync(new UpdateProjPage(new UpdateProjVM { Project = Project, Navigation=this.Navigation}));
        }
    }

}
