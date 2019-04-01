using AgendaXamarinForms.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AgendaXamarinForms
{
    public partial class App : Application
    {
        public SQLiteConnection Connection { get; private set; }

        public static App Instance => App.Current as App;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            Connection = new SQLiteConnection(Path.Combine(path, "data.db"));
            Connection.CreateTable<Contato>();

            if(Connection.Table<Contato>().Count() == 0)
            {
                Connection.InsertAll(new List<Contato>()
                {
                    new Contato { Nome = "Yan", Telefone = "0800" },
                    new Contato { Nome = "Xamarin", Telefone = "0500" },
                    new Contato { Nome = "Forms", Telefone = "0300" },
                });
            }
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
