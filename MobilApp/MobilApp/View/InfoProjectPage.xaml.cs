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
        public InfoProjectPage(InfoProjVM projViewModel)
        {
            InitializeComponent();
            BindingContext = projViewModel;
        }
        //private void Fill()
        //{
        //    EnPhone.Text = pr.PhoneNum;
        //    EnAddress.Text = pr.Adress;
        //    EnEmail.Text = pr.Email;
        //    lblDes.Text = pr.Description;

        //}
        
        
    }
}