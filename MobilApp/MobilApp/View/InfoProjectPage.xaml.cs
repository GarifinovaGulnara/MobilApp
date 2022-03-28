using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilApp.db;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobilApp.ViewModel;
using MobilApp.Model;

namespace MobilApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoProjectPage : TabbedPage
    {
        public static string Name;
        ProjectModel pr;
        public InfoProjectPage(ProjVM projViewModel)
        {
            InitializeComponent();
            //Name = proj.Name;
            //pr = proj;
            //Fill();
            //ViewModel = projViewModel;
            //this.BindingContext = ViewModel;
        }
        private void Fill()
        {
            EnPhone.Text = pr.PhoneNum;
            EnAddress.Text = pr.Adress;
            EnEmail.Text = pr.Email;
            lblDes.Text = pr.Description;

        }
        
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UpdateProjPage(pr));
        }
    }
}