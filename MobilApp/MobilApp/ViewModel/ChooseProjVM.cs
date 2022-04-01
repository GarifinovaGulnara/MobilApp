using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using MobilApp.View;
using System.Windows.Input;
using MobilApp.db;
using System.Collections.ObjectModel;

namespace MobilApp.ViewModel
{
    public class ChooseProjVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigation Navigation { get; set; }
        public ICommand OpenProjCommand { get; protected set; }
        public ICommand CreateProjCommand { protected set;get;}
        InfoProjVM selectedProj;
        public ObservableCollection<InfoProjVM> ProjList { get => projList; set { projList = value; OnPropertyChanged("ProjList"); } }
        public ObservableCollection<InfoProjVM> projList;


        public ChooseProjVM()
        {
            ProjList = new ObservableCollection<InfoProjVM>();
            GetList();
            CreateProjCommand = new Command(CreateBtn);
            
        }

        private void CreateBtn()
        {
            Navigation.PushAsync(new CreateProjPage(new CreateProjVM { Navigation = this.Navigation}));
        }
        public void GetList()
        {
            var a = App.Db.GetProjects();
            foreach (var item in a)
            {
                ProjList.Add(new InfoProjVM { Project = item});
            }
        }

        public InfoProjVM SelectedProj
        {
            get { return selectedProj; }
            set
            {
                if (selectedProj != value)
                {
                    InfoProjVM tempProj = value;
                    tempProj.Navigation = this.Navigation;
                    selectedProj = null;
                    OnPropertyChanged("SelectedProj");
                    Navigation.PushAsync(new InfoProjectPage(tempProj));
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
