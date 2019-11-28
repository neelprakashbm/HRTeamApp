using System;
using HRApp.Views;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRApp
{
    public partial class App : Application
    {
        private SQLiteAsyncConnection connection;
        public App()
        {
            InitializeComponent();            

            MainPage = new NavigationPage();
            MainPage = new NavigationPage(new LoginPage());
            /*(MainPage as MasterDetailPage).Detail = new NavigationPage(new CreateJob());*/            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            connection.CreateTableAsync<CandidateReferral>();

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
