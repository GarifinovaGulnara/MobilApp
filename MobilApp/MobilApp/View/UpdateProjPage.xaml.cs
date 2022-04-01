using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobilApp.db;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobilApp.ViewModel;

namespace MobilApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateProjPage : ContentPage
    {
        
        public UpdateProjPage(UpdateProjVM proj)
        {
            InitializeComponent();
            BindingContext = proj;
        }
    }
}