using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilApp.db;
using MobilApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseProject : ContentPage
    {
        public ChooseProject()
        {
            BindingContext = new ChooseProjVM { Navigation = this.Navigation };
            InitializeComponent();
            

        }
    }
}