using MobilApp.db;
using System;
using System.IO;
using Xamarin.Forms;
using MobilApp.View;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "MaterialIconsFont")]
namespace MobilApp
{
    public partial class App : Application
    {
        public const string DB_NAME = "clientsProj.db";
        public static CRUDOperation db;
        public static CRUDOperation Db
        {
            get
            {
                if (db == null)
                {
                    db = new CRUDOperation(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DB_NAME));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
