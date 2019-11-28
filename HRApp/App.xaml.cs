using System;
using HRApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

<<<<<<< HEAD
            MainPage = new NavigationPage(new CreateJob());
=======
            MainPage = new MasterPage();
            (MainPage as MasterDetailPage).Detail = new NavigationPage(new JobCreation());            
>>>>>>> 1994e50... Hamburger menu and Proxima nova font added
        }

        protected override void OnStart()
        {
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
