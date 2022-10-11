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
    public partial class AnimalsPage : ContentPage
    {
        public AnimalsPage()
        {
            InitializeComponent();
        }
        public AnimalsPage(AnimalCategory category)
        {
            InitializeComponent();
            animal.Text = category.categoryName;
            //DisplayAlert("", category.ToString(), "");

            //List<Animal> animals = new List<Animal>();

            //if (category.categoryID == "khi")
            //{
            //    animals.Add(new Animal
            //    {
            //        nameVN = "Khỉ đuôi dài",
            //        nameLatin = "Macaca fascicularis",
            //        animalImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/Bonnet_macaque%2C_Bangalore.jpg/300px-Bonnet_macaque%2C_Bangalore.jpg",
            //        relative = "Khỉ Cercopithecidae",
            //        set = "Linh trưởng"
            //    });
            //}
            //LstAnimal.ItemsSource = animals;
        }


        private void LstAnimal_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}