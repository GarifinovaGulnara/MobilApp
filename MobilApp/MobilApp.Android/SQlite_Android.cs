using MobilApp.db;
using System.IO;
using System;
using Xamarin.Forms;
using MobilApp.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(SQlite_Android))]
namespace MobilApp.Droid
{
    public class SQlite_Android : ISqlite
    {
        public SQlite_Android() { }
        public string GetDatabasePath(string filename)
        {
            string documentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, filename);
            return path;
        }
    }
}