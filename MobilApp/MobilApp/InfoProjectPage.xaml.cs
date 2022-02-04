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
    public partial class InfoProjectPage : TabbedPage
    {
        public static string Name;
        public InfoProjectPage(Proj proj)
        {
            Name = proj.Name;
            InitializeComponent();
        }
    }
}