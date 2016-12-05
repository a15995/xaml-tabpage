using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Tabpage
{
    public partial class App : Application
    {
        private TabbedPage myTabbedPage = new TabbedPage();
        //private Page1 page1 = new Page1();
        //private PageA pageA = new PageA();
        private NavigationPage navigationPageNumbers = new NavigationPage();
        private NavigationPage navigationPageLetters = new NavigationPage();

        public App()
        {
            InitializeComponent();
            MainPage = myTabbedPage;

            navigationPageNumbers.Title = "Tab Numbers";
            navigationPageLetters.Title = "Tab Letters";
            //myTabbedPage.Children.Add(page1);
            //myTabbedPage.Children.Add(pageA);

            //myTabbedPage.Children.Add(navigationPageLetters);
            //myTabbedPage.Children.Add(navigationPageNumbers);

            // Constructors kan ikke være async, derfor pusher vi først sider til
            // navigationsstakken i OnStart-metoden, som _kan_ modificeres til at være async
        }

        // Bemærk at OnStart blev modificeret til at være async.
        protected override async void OnStart()
        {
            var page1 = new Page1();
            var pageA = new PageA();
            await navigationPageNumbers.PushAsync(page1);
            await navigationPageLetters.PushAsync(pageA);
            
            myTabbedPage.Children.Add(navigationPageLetters);
            myTabbedPage.Children.Add(navigationPageNumbers);
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
