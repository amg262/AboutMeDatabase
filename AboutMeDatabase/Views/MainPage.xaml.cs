using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AboutMeDatabase.Models;
using Xamarin.Forms;

namespace AboutMeDatabase
{
    public partial class MainPage : ContentPage
    {
        private object listView;

        public MainPage()
        {
            InitializeComponent();
        }
        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            FactsAboutMe fact = (FactsAboutMe)e.SelectedItem;
            DisplayAlert("The Fact", fact.TheFact, "Ok");
        }

    }
}
