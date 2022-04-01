using System;
using System.Collections.Generic;
using System.Linq;
using MobilApp.db;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobilApp.ViewModel;

namespace MobilApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateProjPage : ContentPage
    {
        public CreateProjPage(CreateProjVM createProjVM)
        {
            InitializeComponent();
            BindingContext = createProjVM;
        }

    }
}