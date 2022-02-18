using System;
using System.Collections.Generic;
using System.Linq;
using MobilApp.db;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateProjPage : ContentPage
    {
        public CreateProjPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Db.SaveItem(new ProjectModel(NameProj.Text, AboutProj.Text, Phone.Text, Email.Text, Address.Text));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            NameProj.Text = " ";
            AboutProj.Text = " ";
            Phone.Text = " ";
            Email.Text = " ";
            Address.Text = " ";
        }
    }
}