using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CA1.Classes
{
    public class Car : Vehicle
    {
        public enum CarBodyType {Convertible,Hatchback, Coupe, Estate , MPV, SUV, Saloon, Unlisted}
        

        private CarBodyType bodyType;

        #region Accessors
        public CarBodyType BodyType
        {
            get
            {
                return bodyType;
            }

            set
            {
                bodyType = value;
            }
        }
        #endregion
        public Car(string make, string model, decimal price, int year, string color, decimal mileage, string description, BitmapImage image, CarBodyType bodyType) :base(make, model, price, year, color,  mileage,description,image)
        {
            this.bodyType = bodyType;
            
        }
    }
}
