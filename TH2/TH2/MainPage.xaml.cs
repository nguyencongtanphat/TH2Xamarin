using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TH2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void cmdLocations_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LocationsPage());
        }

        private void cmdAnimals_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AnimalCategories());
        }
    }
}
