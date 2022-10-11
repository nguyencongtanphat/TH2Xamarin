using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TH2
{
    public class Hotel : INotifyPropertyChanged
    {
       public string HotelID { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string Introduce { get; set; }
        public string Image { get; set; }
        public bool _IsBook { get; set; }

      

        public bool IsBook
        {
            get { return _IsBook; }
            set
            {
                if (_IsBook != value)
                {
                    _IsBook = value;
                    OnPropertyChanged("IsBook");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
