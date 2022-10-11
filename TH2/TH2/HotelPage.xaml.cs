using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HotelPage : ContentPage
    {
        ObservableCollection<Hotel> hotelsList;
        public HotelPage()
        {
            InitializeComponent();
        }

        public HotelPage(Location location)
        {
            InitializeComponent();
            Title = location.LocationName;
            InitializeHotel(location);
        }

        private void InitializeHotel(Location lct)
        {
          
            hotelsList   = new ObservableCollection<Hotel>();
            //Dalat
            if(lct.LocationId == "DL")
            {
                hotelsList.Add(new Hotel
                {
                    HotelID = "DL01",
                    HotelName = "Hotel Colline",
                    Address = "10 Phan Boi Chau Street, Ward 1, Da Lat",
                    Introduce = "Nằm ở trung tâm thành phố Đà Lạt, cách Quảng trường Lâm Viên 500 m, Hotel Colline có quầy bar và các phòng với truy cập Wi-Fi miễn phí." +
                     " Khách sạn này nằm cách Hồ Xuân Hương 200 m và cách công viên Yersin 500 m.",
                    Image = "hotel_colline.webp",
                    IsBook=false,
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "DL02",
                    HotelName = "Terracotta Hotel & Resort",
                    Address = "Zone 7.9, Tuyen Lam Lake Tourist Area, Ward 3, Tuyen Lam Lake, Da Lat",
                    Introduce = "Terracotta Hotel & Resort Dalat cung cấp các phòng và biệt thự với Wi-Fi miễn phí." +
                    " Resort nằm cạnh Hồ Tuyền Lâm đồng thời có hồ bơi trong nhà, trung tâm thể dục và spa.",
                    Image = "Terracotta_Hotel_Resort_Dalat.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "DL03",
                    HotelName = "Ana Villas",
                    Address = "Le Lai Street, Ward 5, Da Lat",
                    Introduce = "Ana Villas Dalat Resort & Spa cung cấp các biệt thự kiểu thuộc địa Pháp nguyên bản tại một vị trí lý tưởng trên những sườn dốc của vùng cao nguyên nông thôn ở thành phố Đà Lạt." +
                    " Resort này có hồ bơi ngoài trời, trung tâm spa và nhà hàng trong khuôn viên. Du khách có thể sử dụng WiFi miễn phí ở các khu vực chung và chỗ đỗ xe riêng miễn phí trong khuôn viên.",
                    Image = "Ana_Villas_Dalat_Resort_Spa.webp"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "DL04",
                    HotelName = "Kings Hotel",
                    Address = "10 Bui Thi Xuan, Da Lat",
                    Introduce = "Khách sạn Kings Hotel Dalat nằm tại thành phố Đà Lạt này có tiện nghi BBQ và trung tâm spa." +
                    " Khách sạn có phòng xông hơi khô và trung tâm thể dục đồng thời khách có thể dùng bữa trong nhà hàng. WiFi trong toàn bộ khuôn viên và chỗ đỗ xe riêng tại chỗ đều được cung cấp miễn phí.",
                    Image = "Kings_Hotel_Dalat.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "DL05",
                    HotelName = "Dalat Palace Heritage",
                    Address = "02 Tran Phu Street, Ward 3, Da Lat",
                    Introduce = "Dalat Palace Hotel tọa lạc tại trung tâm thành phố Đà Lạt, cách Dinh Bảo Đại chưa đến 300 m." +
                    " Tọa lạc trong một công viên tư nhân, khách sạn thông gió tự nhiên này có nhà hàng, spa và Wi-Fi miễn phí.",
                    Image = "Dalat_Palace_Heritage_Hotel.webp"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "DL05",
                    HotelName = "Dalat Palace Heritage",
                    Address = "02 Tran Phu Street, Ward 3, Da Lat",
                    Introduce = "Dalat Palace Hotel tọa lạc tại trung tâm thành phố Đà Lạt, cách Dinh Bảo Đại chưa đến 300 m." +
                   " Tọa lạc trong một công viên tư nhân, khách sạn thông gió tự nhiên này có nhà hàng, spa và Wi-Fi miễn phí.",
                    Image = "Dalat_Palace_Heritage_Hotel.webp"
                });
                hotelsList.Add(new Hotel
                {
                    HotelID = "DL05",
                    HotelName = "Dalat Palace Heritage",
                    Address = "02 Tran Phu Street, Ward 3, Da Lat",
                    Introduce = "Dalat Palace Hotel tọa lạc tại trung tâm thành phố Đà Lạt, cách Dinh Bảo Đại chưa đến 300 m." +
                   " Tọa lạc trong một công viên tư nhân, khách sạn thông gió tự nhiên này có nhà hàng, spa và Wi-Fi miễn phí.",
                    Image = "Dalat_Palace_Heritage_Hotel.webp"
                });
                hotelsList.Add(new Hotel
                {
                    HotelID = "DL05",
                    HotelName = "Dalat Palace Heritage",
                    Address = "02 Tran Phu Street, Ward 3, Da Lat",
                    Introduce = "Dalat Palace Hotel tọa lạc tại trung tâm thành phố Đà Lạt, cách Dinh Bảo Đại chưa đến 300 m." +
                   " Tọa lạc trong một công viên tư nhân, khách sạn thông gió tự nhiên này có nhà hàng, spa và Wi-Fi miễn phí.",
                    Image = "Dalat_Palace_Heritage_Hotel.webp"
                });
                hotelsList.Add(new Hotel
                {
                    HotelID = "DL05",
                    HotelName = "Dalat Palace Heritage",
                    Address = "02 Tran Phu Street, Ward 3, Da Lat",
                    Introduce = "Dalat Palace Hotel tọa lạc tại trung tâm thành phố Đà Lạt, cách Dinh Bảo Đại chưa đến 300 m." +
                   " Tọa lạc trong một công viên tư nhân, khách sạn thông gió tự nhiên này có nhà hàng, spa và Wi-Fi miễn phí.",
                    Image = "Dalat_Palace_Heritage_Hotel.webp"
                });
            }
            // Vung Tau.
            else if (lct.LocationId == "VT")
            {
                hotelsList.Add(new Hotel
                {
                    HotelID = "VT01",
                    HotelName = "The Imperial Hotel",
                    Address = "159 Thuy Van Street, Vung Tau",
                    Introduce = "The Imperial Hotel Vung Tau có khu vực bãi biển riêng và cung cấp chỗ nghỉ với lối trang trí thời Victoria ở khu vực Bãi Sau." +
                    " Khách sạn có hồ bơi ngoài trời và 4 địa điểm ăn uống. Khách có thể sử dụng Wi-Fi miễn phí trong toàn khuôn viên.",
                    Image = "The_Imperial_Hotel.webp"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "VT02",
                    HotelName = "Pullman",
                    Address = "15 Thi Sach, Thang Tam, Vung Tau",
                    Introduce = "Nằm ở thành phố Vũng Tàu, cách Bãi Sau 450 m, Pullman Vung Tau cung cấp chỗ nghỉ với nhà hàng, chỗ đỗ xe riêng miễn phí, hồ bơi ngoài trời và trung tâm thể dục." +
                    " Trong số nhiều tiện nghi của khách sạn này còn có quán bar, khu vườn và khu vực bãi biển riêng. Chỗ nghỉ cung cấp dịch vụ lễ tân 24 giờ, dịch vụ phòng và dịch vụ thu đổi ngoại tệ cho khách.",
                    Image = "Pullman_VungTau.webp"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "VT03",
                    HotelName = "Fusion Suites",
                    Address = "02 Truong Cong Dinh Street, Ward 2, Vung Tau City, BR-VT",
                    Introduce = "Nằm ở thành phố Vũng Tàu, cách Bãi Sau 1,8 km, Fusion Suites Vung Tau cung cấp chỗ nghỉ với nhà hàng, chỗ đỗ xe riêng miễn phí, trung tâm thể dục và quầy bar." +
                    " Khách sạn 4 sao này cũng cung cấp khu vườn, sân hiên, Chỗ nghỉ có lễ tân 24 giờ, dịch vụ phòng và dịch vụ thu đổi ngoại tệ cho khách.",
                    Image = "Fusion_Suites_VungTau.webp"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "VT04",
                    HotelName = "Marina Bay",
                    Address = "115 Tran Phu, Vung Tau",
                    Introduce = "Marina Bay Vung Tau Resort & Spa có nhà hàng, hồ bơi ngoài trời, trung tâm thể dục và quán bar ở thành phố Vũng Tàu." +
                    " Các tiện nghi của chỗ nghỉ bao gồm dịch vụ lễ tân 24 giờ, dịch vụ phòng và WiFi miễn phí trong toàn bộ khuôn viên. Resort còn có vườn và sân hiên tắm nắng.",
                    Image = "Marina_Bay_VungTau_Resort_Spa.webp"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "VT05",
                    HotelName = "Malibu Hotel",
                    Address = "263 Le Hong Phong, Vung Tau",
                    Introduce = "Tọa lạc trong một tòa nhà chọc trời màu xám, hiện đại và nổi bật, Malibu Hotel cung cấp chỗ nghỉ đẹp mắt tại thành phố Vũng Tàu." +
                    " Khách sạn có hồ bơi vô cực thú vị nhìn ra khu vực Vũng Tàu. Khách nghỉ tại đây có thể lựa chọn thư giãn đôi chút tại spa hoặc thậm chí rèn luyện sức khỏe ở trung tâm thể dục. Bạn đồng hành tuyệt vời và cocktail hảo hạng đang chờ đón du khách tại sảnh khách cũng như các quầy bar ngay trong khuôn viên. Wi-Fi miễn phí có trong tất cả các khu vực của chỗ nghỉ.",
                    Image = "Malibu_Hotel.webp"
                });
            }
            // Phu Quoc.
            else if (lct.LocationId == "PQ")
            {
                hotelsList.Add(new Hotel
                {
                    HotelID = "PQ01",
                    HotelName = "Sunset Beach",
                    Address = "100/2 Tran Hung Dao Street, Duong To, Duong Dong, Phu Quoc",
                    Introduce = "Tọa lạc tại đảo Phú Quốc, cách Chùa Sùng Hưng 1,9 km, Sunset Beach Resort and Spa có nhà hàng, chỗ đỗ xe riêng miễn phí, hồ bơi ngoài trời và trung tâm thể dục." +
                    " Các tiện nghi của chỗ nghỉ bao gồm dịch vụ lễ tân 24 giờ, dịch vụ phòng và WiFi miễn phí trong toàn bộ khuôn viên. Khách sạn cũng có hồ bơi trong nhà và phòng giữ hành lý.",
                    Image = "Sunset_Beach_Resort_Spa.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "PQ02",
                    HotelName = "Movenpick Residences",
                    Address = "Ong Lang Beach, Cua Duong Village, Ong Lang, 92000 Phu Quoc",
                    Introduce = "Tọa lạc tại đảo Phú Quốc, Mövenpick Residences Phu Quoc có nhà hàng, hồ bơi ngoài trời, quán bar và sảnh khách chung." +
                    " Mỗi phòng nghỉ tại khách sạn 5 sao này đều có tầm nhìn ra hồ nước, khu vườn và khu vực bãi biển riêng. Chỗ nghỉ cung cấp dịch vụ lễ tân 24 giờ, dịch vụ phòng và dịch vụ thu đổi ngoại tệ cho khách.",
                    Image = "Movenpick_Residences_PhuQuoc.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "PQ03",
                    HotelName = "Sen Hotel",
                    Address = "63 Tran Hung Dao Street, Phu Quoc, Duong Dong, Phu Quoc",
                    Introduce = "Sen Hotel Phu Quoc tọa lạc bên bờ biển ở đảo Phú Quốc, cách Chùa Sùng Hưng 500 m và Sòng bạc Corona 22 km." +
                    " Trong số các tiện nghi của chỗ nghỉ này có nhà hàng, lễ tân 24 giờ, dịch vụ phòng và WiFi miễn phí trong toàn bộ khuôn viên. Khách sạn cung cấp phòng gia đình.",
                    Image = "Sen_Hotel_PhuQuoc.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "PQ04",
                    HotelName = "Seashells Phu Quoc",
                    Address = "1 Vo Thi Sau, Duong Dong, Phu Quoc",
                    Introduce = "Seashells Phu Quoc Hotel & Spa tọa lạc ở thị trấn Dương Đông, đảo Phú Quốc và sở hữu các phòng nghỉ hiện đại với kết nối WiFi miễn phí." +
                    " Khách sạn này có hồ bơi ngoài trời cùng nhà hàng, quán bar và chỗ đỗ xe riêng miễn phí trong khuôn viên.",
                    Image = "Seashells_PhuQuoc_Hotel_Spa.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "PQ05",
                    HotelName = "Fusion Resort",
                    Address = "Vung Bau, Cua Can, Phu Quoc",
                    Introduce = "Cung cấp chỗ ở ấm cúng tại Cửa Cạn, Fusion Resort Phu Quoc có hồ bơi ngoài trời, nhà hàng trong khuôn viên và khu vườn." +
                    " Khách được cung cấp dịch vụ đưa đón sân bay miễn phí với lịch trình cố định và truy cập Wi-Fi miễn phí trong toàn bộ khu vực.",
                    Image = "Fusion_Resort_PhuQuoc.jpg"
                });
            }
            // Ha Noi.
            else if (lct.LocationId == "HN")
            {
                hotelsList.Add(new Hotel
                {
                    HotelID = "HN01",
                    HotelName = "Peridot Grand by AIRA",
                    Address = "33 Duong Thanh, Hoan Kiem District, Ha Noi",
                    Introduce = "Tọa lạc tại thành phố Hà Nội, Peridot Grand Hotel & Spa by AIRA có 2 nhà hàng trong khuôn viên, 3 quán bar, hồ bơi ngoài trời, trung tâm thể dục và quán bar." +
                    " Khách sạn 5 sao này cũng có sảnh khách chung và dịch vụ concierge. Chỗ nghỉ cung cấp dịch vụ lễ tân 24 giờ, dịch vụ phòng và dịch vụ thu đổi ngoại tệ cho khách.",
                    Image = "Peridot_Grand_Hotel_Spa_by_AIRA.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "HN02",
                    HotelName = "Solaria Hanoi",
                    Address = "22 Bao Khanh, Hoan Kiem District, Ha Noi",
                    Introduce = "Tọa lạc ở thành phố Hà Nội, cách Nhà Thờ Lớn 300 m, Solaria Hanoi Hotel có quầy bar, sân hiên và tầm nhìn ra quang cảnh thành phố." +
                    " Trong số các tiện nghi của khách sạn này còn có nhà hàng, lễ tân 24 giờ, dịch vụ phòng và WiFi miễn phí trong toàn bộ khuôn viên. Khách sạn cung cấp các phòng gia đình.",
                    Image = "Solaria_Hanoi_Hotel.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "HN03",
                    HotelName = "Acoustic Hotel & Spa",
                    Address = "39 Tho Nhuom, Hoan Kiem District, Ha Noi",
                    Introduce = "Tọa lạc tại thành phố Hà Nội, Acoustic Hotel & Spa có nhà hàng, xe đạp cho khách sử dụng miễn phí, trung tâm thể dục và quán bar." +
                    " Khách sạn này có các phòng gia đình và sân hiên. Chỗ nghỉ cung cấp dịch vụ lễ tân 24 giờ, dịch vụ phòng và dịch vụ thu đổi ngoại tệ cho khách.",
                    Image = "Acoustic_Hotel_Spa.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "HN04",
                    HotelName = "Sofitel Legend Metropole",
                    Address = "15 Ngo Quyen Street, Hoan Kiem District, Ha Noi",
                    Introduce = "Là địa danh lịch sử sang trọng từ năm 1901, Sofitel Legend Metropole có các dịch vụ spa thư giãn, dịch vụ phòng 24 giờ và hồ bơi nước nóng." +
                    " Khách sạn tọa lạc ở trung tâm thủ đô Hà Nội, gần Khu Phố Cổ.",
                    Image = "Sofitel_Legend_Metropole_Hanoi.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "HN05",
                    HotelName = "Paradise Center",
                    Address = "22/5 Hang Voi Street, Ly Thai To Ward, Hoan Kiem District, Ha Noi",
                    Introduce = "Tọa lạc tại thành phố Hà Nội, cách Nhà hát múa rối nước Thăng Long 400 m, Hanoi Paradise Center Hotel & Spa cung cấp chỗ nghỉ với nhà hàng, chỗ đỗ xe riêng miễn phí, quán bar và sảnh khách chung." +
                    " Khách sạn này có các phòng gia đình và sân hiên. Chỗ nghỉ cũng cung cấp dịch vụ lễ tân 24 giờ, dịch vụ phòng và dịch vụ thu đổi ngoại tệ cho khách.",
                    Image = "Hanoi_Paradise_Center_Hotel_Spa.webp"
                });
            }
            // Ho Chi Minh.
            else if (lct.LocationId == "HCM")
            {
                hotelsList.Add(new Hotel
                {
                    HotelID = "HCM01",
                    HotelName = "Winsuites Saigon",
                    Address = "28-30-32 Le Lai Street, Ben Thanh Ward, District 1, HCM City",
                    Introduce = "Tọa lạc tại Thành phố Hồ Chí Minh, Winsuites Saigon có nhà hàng, hồ bơi ngoài trời, trung tâm thể dục và quán bar." +
                    " Khách sạn 4 sao này còn có dịch vụ tiền sảnh và bàn đặt tour. Chỗ nghỉ cung cấp dịch vụ lễ tân 24 giờ, dịch vụ đưa đón sân bay, dịch vụ phòng và WiFi miễn phí trong toàn bộ khuôn viên.",
                    Image = "Winsuites_Saigon.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "HCM02",
                    HotelName = "Icon Saigon",
                    Address = "65-67 Hai Ba Trung, District 1, HCM City",
                    Introduce = "Tọa lạc ở Thành phố Hồ Chí Minh, Icon Saigon - LifeStyle Hotel có nhà hàng, hồ bơi ngoài trời, trung tâm thể dục và quầy bar." +
                    " Khách sạn 4 sao này cung cấp WiFi miễn phí, dịch vụ lễ tân 24 giờ và dịch vụ phòng. Chỗ nghỉ nằm gần các điểm tham quan nổi tiếng như Trụ sở UBND Thành phố Hồ Chí Minh, Bưu điện Trung tâm Sài Gòn và Nhà thờ Đức Bà.",
                    Image = "Icon_Saigon_LifeStyle_Design_Hotel.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "HCM03",
                    HotelName = "The Myst Dong Khoi",
                    Address = "6-8 Ho Huan Nghiep, District 1, HCM City",
                    Introduce = "Với thiết kế và nội thất hiện đại cổ điển, The Myst Dong Khoi cung cấp chỗ nghỉ tinh tế ở khu trung tâm Quận 1 tại Thành phố Hồ Chí Minh." +
                    " Du khách có thể ngâm mình thư giãn trong hồ bơi trên sân thượng, hoặc đơn giản là ngắm nhìn thành phố bên sông Sài Gòn từ sàn hồ bơi.",
                    Image = "The_Myst_Dong_Khoi.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "HCM04",
                    HotelName = "Grand Hotel Saigon",
                    Address = "8 Dong Khoi Street, District 1, HCM City",
                    Introduce = "Nằm trong toà nhà kiểu thuộc địa được khôi phục lại, Grand Hotel Saigon cung cấp chỗ nghỉ rộng rãi tại Quận 1, thành phố Hồ Chí Minh." +
                    " Khách sạn có hồ bơi ngoài trời, 2 nhà hàng trong khuôn viên và WiFi miễn phí.",
                    Image = "Grand_Hotel_Saigon.jpg"
                });

                hotelsList.Add(new Hotel
                {
                    HotelID = "HCM05",
                    HotelName = "Caravelle Saigon",
                    Address = "19-23 Lam Son Square, District 1, HCM City",
                    Introduce = "Khai trương vào năm 1959, khách sạn 5 sao Caravelle Saigon có phong cách kiến trúc kiểu Pháp và Việt Nam đẹp mắt, hồ bơi ngoài trời cùng phòng không hút thuốc đi kèm Wi-Fi miễn phí." +
                    " Nằm trong bán kính chỉ 50 m từ Nhà hát thành phố nổi tiếng ở Thành phố Hồ Chí Minh, khách sạn thân thiện với môi trường này cũng có quán bar trên sân thượng biểu diễn nhạc sống.",
                    Image = "Caravelle_Saigon.jpg"
                });
            }

            LstHotel.ItemsSource = hotelsList;
        }

        private void cmdRemoveLast_Clicked(object sender, EventArgs e)
        {
            hotelsList.RemoveAt(hotelsList.Count-1);
        }

  

     
        private int findIndex(string id)
        {
            int lengthList = hotelsList.Count;
            for (int i = 0; i < lengthList; i++)
            {
                if (hotelsList[i].HotelID == id)
                {
                    return i;
                }
            }
            return -1;
        }

        private void cmdChangeStatus_Clicked(object sender, EventArgs e)
        {
            string id = ((MenuItem)sender).CommandParameter.ToString();
            int index = findIndex(id);
            if (index != -1)
            {
                hotelsList[index].IsBook = !hotelsList[index].IsBook;
                DisplayAlert("Thông báo", "Bạn đã thay đổi trạng thái thành công"+ hotelsList[index].IsBook.ToString(), "OK");
            }

        }

        private async void cmdDeleteItem_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Delete", "Do you want to delete?", "Yes", "No");
           
            if (response)
            {
                string id = ((MenuItem)sender).CommandParameter.ToString();
                int index = findIndex(id);
                if (index != -1)
                {
                    hotelsList.RemoveAt(index);
                }
            }
            
            


        }

        private void refreshAct_Refreshing(object sender, EventArgs e)
        {
            LstHotel.ItemsSource = hotelsList;
            DisplayAlert("", hotelsList[0].IsBook.ToString(), "ok");
            refreshAct.IsRefreshing = false;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            LstHotel.ItemsSource = hotelsList.Where(item => item.HotelName.Contains(e.NewTextValue));
        }
    }
}