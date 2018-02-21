using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CA1.Classes
{
    public abstract class Vehicle
    {
        private string make;
        private string model;
        private decimal price;
        private int year;
        private string color;
        private decimal mileage;
        private string description;
        private BitmapImage image;

        public Vehicle(string make, string model, decimal price, int year, string color, decimal mileage, string description, BitmapImage image)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.year = year;
            this.color = color;
            this.mileage = mileage;
            this.description = description;
            this.image = image;
        }

        #region Accessors
        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public decimal Mileage
        {
            get
            {
                return mileage;
            }

            set
            {
                mileage = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public BitmapImage Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        #endregion


    }
}
