using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using MobilApp.db;
using System.Windows.Input;

namespace MobilApp.ViewModel
{
    public class CreateProjVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigation Navigation { get; set; }
        public ICommand CreateCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        public ProjectModel Project { get; set; }

        public CreateProjVM()
        {
            Project = new ProjectModel("", "","","","");
            CreateCommand = new Command(CreateBtn);
            BackCommand = new Command(Back);
        }
        private async void CreateBtn()
        {
            try
            {
                App.Db.SaveItem(Project);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("", ex.Message, "ok");
            }
        }

        public string Name { get => Project.Name; set { Project.Name = value; OnPropertyChanged("Name"); } }
        public string Description { get => Project.Description; set { Project.Description = value; OnPropertyChanged("Description"); } }
        public string PhoneNum { get => Project.PhoneNum; set { Project.PhoneNum = value; OnPropertyChanged("PhoneNum"); } }
        public string Email { get => Project.Email; set { Project.Email = value; OnPropertyChanged("Email"); } }
        public string Adress { get => Project.Adress; set { Project.Adress = value; OnPropertyChanged("Adress"); } }
        private void Back()
        {
            Navigation.PopAsync();
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
