using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CA1.Classes
{
    public class Van : Vehicle
    {
        public enum VanType { CombiVan,Dropside, PanelVan, Pickup, Tipper, Unlisted}
        public enum Wheelbase { Short, Medium, Long, Unlisted}
        private VanType type;
        private Wheelbase wBase;

        
        public Van(string make, string model, decimal price, int year, string color, decimal mileage, string description, BitmapImage image, VanType vanType, Wheelbase wheelBase) :base(make, model, price, year, color,  mileage,description,image)
        {
            this.type = vanType;
            this.wBase = wheelBase;
        }
    }
}
