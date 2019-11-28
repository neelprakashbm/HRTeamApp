using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        MasterDetailPage mainPage;
        public MasterPage()
        {
            InitializeComponent();

            SetupMenu();            
        }

        public void SetupMenu()
        {
            var menuList = new List<MenuItem>
            {
                new MenuItem{ Title = "Create Job", IsAdminMenu= true, Image = "money.png" },
                new MenuItem{ Title = "Job Openings", Image = "component.png"},
                new MenuItem{ Title= "Signout", Image = "signout.png"}
            };

            listView.ItemsSource = menuList;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            mainPage = Application.Current.MainPage as MasterDetailPage;
            var menu = e.Item as MenuItem;
            switch (menu.Title)
            {
                case "Create Job":
                    mainPage.Detail = new NavigationPage(new CreateJob());
                    break;

                case "Job Openings":
                    mainPage.Detail = new NavigationPage(new JobListPage());
                    break;

                case "Report":
                    mainPage.Detail = new NavigationPage(new JobListPage());
                    break;

                case "Signout":
                    mainPage.Detail = new NavigationPage(new LoginPage());
                    break;

            }

            mainPage.IsPresented = false;
        }

        private void Synch(object sender, EventArgs e)
        {
            //mainPage = Application.Current.MainPage as MasterDetailPage;
            //mainPage.Detail = new NavigationPage(new SyncData());
        }
    }
}
