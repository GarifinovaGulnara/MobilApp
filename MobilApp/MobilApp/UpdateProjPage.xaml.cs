using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateProjPage : ContentPage
    {
        public UpdateProjPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Db.SaveItem(new db.ProjectModel(NameProj.Text, AboutProj.Text, Phone.Text, Email.Text, Address.Text));
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