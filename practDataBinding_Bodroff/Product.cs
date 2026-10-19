using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practDataBinding_Bodroff
{
    internal class Product : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private int id = 0;

        public int Id
        {
             get
             {
                 return id;
             }
             set
             {
                 if (id != value)
                 {
                     id = value;
                     OnPropertyChanged();
                 }
             }
        }

        private string name = "";

        public string Name
        {
             get
             {
                return name;
             }
             set
             {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
             }
        }

        private string category = "";

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                if (category != value)
                {
                    category = value;
                    OnPropertyChanged();
                }
            }
        }

        private double price = 0;

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TotalCost));
                }
            }
        }

        private int quantity = 0;

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TotalCost));
                }
            }
        }

        public double TotalCost
        {
            get
            {
                return Price * Quantity;
            }
          
        }



    }
}
