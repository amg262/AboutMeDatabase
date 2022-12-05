using System;
using System.Collections.Generic;
using AboutMeDatabase.Data;
using AboutMeDatabase.Models;
using Xamarin.Forms;


namespace AboutMeDatabase
{
    public partial class App : Application
    {
        static PersonalItemDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static PersonalItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new PersonalItemDatabase(); 
                    prefillDatabase();

                }
                return database;
            }
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

        static void prefillDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> items = new List<PersonalItem>();
                items.Add(new PersonalItem() { Title = "Name", Detail = "Matt Green" });
                items.Add(new PersonalItem() { Title = "Job", Detail = "Professor" });
                items.Add(new PersonalItem() { Title = "Associate", Detail = "ICC (Illinios Central College) - AAS - Computer Engeneering" });
                items.Add(new PersonalItem() { Title = "Undergraduate", Detail = "EIU (Eastern Illinios Unviersity) - BSB - Computer Managment & Computational Math" });
                items.Add(new PersonalItem() { Title = "Masters", Detail = "CUW (Concordia University Wisconsin) - MSED - Educational Design and Technology" });
                items.Add(new PersonalItem() { Title = "Doctororate (In progress)", Detail = "NTS (Northwind Theological Seminary) - DMin - Doctor in Contextual Ministry Faith-Based Communications" });
                items.Add(new PersonalItem() { Title = "Hobbies", Detail = "Global Travel, Culinary, Grilling/Smoking, Baking, 3D Printing, Painting (Watercolors)" });
                items.Add(new PersonalItem() { Title = "Favorite Foods", Detail = "Pizza (All kinds), Ribey steaks, Numerious international dishes" });
                database.InsertList(items);

        }
    }
}
