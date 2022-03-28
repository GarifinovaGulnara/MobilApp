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
        public ICommand OpenProjCommand { get; set; }
        ProjVM selectedProj;
        public ObservableCollection<ProjectModel> ProjList { get => projList; set { projList = value; OnPropertyChanged("ProjList"); } }
        public ObservableCollection<ProjectModel> projList;


        public ChooseProjVM()
        {
            ProjList = new ObservableCollection<ProjectModel>();
            GetList();
            
        }
        public void GetList()
        {
            var a = App.Db.GetProjects();
            foreach (var item in a)
            {

                ProjList.Add(item);
            }
        }

        public ProjVM SelectedProj
        {
            get { return selectedProj; }
            set
            {
                if (selectedProj != value)
                {
                    ProjVM tempProj = value;
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
