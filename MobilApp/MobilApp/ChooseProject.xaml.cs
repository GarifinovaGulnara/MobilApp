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
    public partial class ChooseProject : ContentPage
    {
        static List<Proj> projects;
        public ChooseProject()
        {
            InitializeComponent();
            GetList();
            ProjList.ItemsSource = projects;
        }

        public static void GetList()
        {
            projects = new List<Proj>();
            for (int i = 1; i<18; i++)
            {
                projects.Add(new Proj($"Проект {i}"));
            }
        }
        
        private void ProjList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new InfoProjectPage((Proj)e.Item));
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateProjPage());
        }
    }
}