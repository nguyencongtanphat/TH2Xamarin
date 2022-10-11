using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationsPage : ContentPage
    {
        public LocationsPage()
        {
            InitializeComponent();
            InitializeLocation();
        }

        private void InitializeLocation()
        {
            List<Location> locationsList = new List<Location>();
            locationsList.Add(new Location { LocationId = "DL", LocationName = "Đà Lạt", Image = "dalat.jpg" });
            locationsList.Add(new Location { LocationId = "VT", LocationName = "Vũng Tàu", Image = "vungtau.jpg" });
            locationsList.Add(new Location { LocationId = "HN", LocationName = "Hà Nội", Image = "phuquoc.jpg" });
            locationsList.Add(new Location { LocationId = "PQ", LocationName = "Phú Quốc", Image = "hanoi.jpg" });
            locationsList.Add(new Location { LocationId = "HCM", LocationName = "Hồ Chí Minh", Image = "hcm.jpg" });

            LstLocations.ItemsSource = locationsList;
        }

        private void LstLocations_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
        }

        private void LstLocations_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(LstLocations.SelectedItem != null)
            {
                Location location = LstLocations.SelectedItem as Location;

                Navigation.PushAsync(new HotelPage(location));
            }
        }
    }
}