using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobilApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {            
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void Reg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }

        private void LogIn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new ChooseProject()));
        }
    }
}
