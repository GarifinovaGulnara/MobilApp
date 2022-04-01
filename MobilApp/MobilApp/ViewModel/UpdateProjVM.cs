using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MobilApp.db;
using System.Windows.Input;
using MobilApp.View;
using Xamarin.Forms;

namespace MobilApp.ViewModel
{
    public class UpdateProjVM : INotifyPropertyChanged
    {
        public ProjectModel Project { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand BackCommand { protected set; get; }
        public ICommand DeleteCommand { protected set; get; }
        public ICommand SaveCommand { protected set; get; }
        public INavigation Navigation { get; set; }
        public UpdateProjVM()
        {
            //Project = new ProjectModel();
            BackCommand = new Command(Back);
            DeleteCommand = new Command(DeleteBtn);
            SaveCommand = new Command(SaveBtn);
        }

        private async void DeleteBtn()
        {
            
            bool answer = await App.Current.MainPage.DisplayAlert("?", $"вы точно хотите удалить ?", "Удалить", "Отмена");
            if (answer == true)
            {
                App.Db.DelProj(Project.Id);
                await Navigation.PushModalAsync(new NavigationPage(new ChooseProject()));
            }
        }

        private async void SaveBtn()
        {
            App.Db.SaveItem(Project); 
            await Navigation.PopAsync();

        }
        private void Back()
        {
             Navigation.PopAsync();
        }
        public string Name { get => Project.Name; set { Project.Name = value; OnPropertyChanged("Name"); } }
        public string Description { get => Project.Description; set { Project.Description = value; OnPropertyChanged("Description"); } }
        public string PhoneNum { get => Project.PhoneNum; set { Project.PhoneNum = value; OnPropertyChanged("PhoneNum"); } }
        public string Email { get => Project.Email; set { Project.Email = value; OnPropertyChanged("Email"); } }
        public string Adress { get => Project.Adress; set { Project.Adress = value; OnPropertyChanged("Adress"); } }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
