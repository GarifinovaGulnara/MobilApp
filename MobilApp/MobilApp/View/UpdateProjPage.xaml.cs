using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilApp.db;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateProjPage : ContentPage
    {
        ProjectModel project;
        public UpdateProjPage( ProjectModel project)
        {
            InitializeComponent();
            this.project = project;
            
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            bool answer = await  DisplayAlert("?", $"вы точно хотите удалить {NameProj.Text}?", "Удалить", "Отмена");
            if (answer == true)
            {
                App.Db.DelProj(project.Id);
                await Navigation.PushModalAsync(new NavigationPage(new ChooseProject()));
            }
        }


        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    App.Db.SaveItem(new db.ProjectModel(NameProj.Text, AboutProj.Text, Phone.Text, Email.Text, Address.Text));
        //}

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}