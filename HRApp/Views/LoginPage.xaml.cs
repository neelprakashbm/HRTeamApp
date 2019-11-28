using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HRApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void GoToCreateJob(object sender, EventArgs e)
        {
            MasterPage fpm = new MasterPage();
            fpm.Detail = new NavigationPage(new CreateJob());
            Application.Current.MainPage = fpm;

        }
        
    }
}
