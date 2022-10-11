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
    public partial class AnimalCategories : ContentPage
    {
        

        public AnimalCategories()
        {
            InitializeComponent();
            InnitializeCategory();
        }

        private void InnitializeCategory()
        {
            List<AnimalCategory> animalCategoryList = new List<AnimalCategory>();
            animalCategoryList.Add(new AnimalCategory { categoryID = "khi", categoryName = "Khỉ", categoryAge = 10, categoryImage = "https://ngonaz.com/wp-content/uploads/2022/03/ve-con-khi-1.jpg" });
            animalCategoryList.Add(new AnimalCategory { categoryID = "ca", categoryName = "Cá", categoryAge = 20, categoryImage = "https://tip.edu.vn/wp-content/uploads/2022/01/Cach-ve-con-ca-hoat-hinh-don-gian-danh-cho.jpg" });
            animalCategoryList.Add(new AnimalCategory { categoryID = "san ho", categoryName = "San Hô", categoryAge = 100, categoryImage = "https://banner2.cleanpng.com/20180306/ydq/kisspng-crxe9teil-cartoon-clip-art-vector-map-coral-5a9ed868dbe656.3630850515203595289007.jpg" });
            animalCategoryList.Add(new AnimalCategory { categoryID = "bo", categoryName = "Bò", categoryAge = 5, categoryImage = "https://free.vector6.com/wp-content/uploads/2020/09/free-vector-000573-phim-hoat-hinh-con-bo-duc-tren-nen-trang.jpg" });
            animalCategoryList.Add(new AnimalCategory { categoryID = "chim", categoryName = "Chim", categoryAge = 10, categoryImage = "https://banner2.cleanpng.com/20180518/trz/kisspng-bird-cartoon-swallow-clip-art-5aff44a2d395e6.5738920615266786908667.jpg" });
            animalCategoryList.Add(new AnimalCategory { categoryID = "ran", categoryName = "Rắn", categoryAge = 10, categoryImage = "https://stockdep.net/files/images/41721962.jpg" });
            animalCategoryList.Add(new AnimalCategory { categoryID = "oc", categoryName = "Ốc", categoryAge = 10, categoryImage = "https://cdn.pixabay.com/photo/2021/05/28/20/41/snail-6292024_640.png" });
            LstCategory.ItemsSource = animalCategoryList;
        }

        private void LstCategory_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (LstCategory.SelectedItem != null)
            {
                AnimalCategory category = LstCategory.SelectedItem as AnimalCategory;

                Navigation.PushAsync(new AnimalsPage(category));
            }
        }
    }
}