using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobilApp.ViewModel;

namespace MobilApp.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainVM { Navigation = this.Navigation };
            InitializeComponent();
        }

    }
}
