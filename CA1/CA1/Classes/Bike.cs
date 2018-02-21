using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CA1.Classes
{
    public class Bike : Vehicle
    {
        public enum BikeType {Scooter, TrailBike, Sports, Commuter, Tourer}
        private BikeType type;

        public BikeType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public Bike(string make, string model, decimal price, int year, string color, decimal mileage, string description, BitmapImage image, BikeType bodyType) :base(make, model, price, year, color,  mileage,description,image)
        {
            this.type = bodyType;
        }
    }
}
