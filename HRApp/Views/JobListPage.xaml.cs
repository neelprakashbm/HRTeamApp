using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HRApp.Views
{
    public partial class JobListPage : ContentPage
    {
        public JobListPage()
        {
            InitializeComponent();
            jobListView.ItemsSource = new List<JobListing>
            {
            new JobListing { JobTitle = ".NET Developer with 4Yr Exp", Positions = "4 Positions", SkillSet = "C#, MVC, SQL Server, Angular" },
            new JobListing { JobTitle = ".NET Developer with 4Yr Exp", Positions = "4 Positions", SkillSet = "C#, MVC, SQL Server, Angular" },
            new JobListing { JobTitle = ".NET Developer with 4Yr Exp", Positions = "4 Positions", SkillSet = "C#, MVC, SQL Server, Angular" },
            new JobListing { JobTitle = ".NET Developer with 4Yr Exp", Positions = "4 Positions", SkillSet = "C#, MVC, SQL Server, Angular" }
        };

        }
        private void GoToJobDetails(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JobDetails());
        }
        

    }
}
