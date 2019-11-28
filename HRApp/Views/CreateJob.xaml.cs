using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HRApp.Views
{
    public partial class CreateJob : ContentPage
    {
        public CreateJob()
        {
            InitializeComponent();
        }

        private void GoToJobListing(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JobListPage());
        }
    }
}
