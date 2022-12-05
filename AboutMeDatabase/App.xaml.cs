using System;
using System.Collections.Generic;
using AboutMeDatabase.Data;
using AboutMeDatabase.Models;
using Xamarin.Forms;


namespace AboutMeDatabase
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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