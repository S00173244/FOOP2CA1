using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CA1.Classes
{
    public class DataHandler
    {
        public List<string[]> ImportData()
        {
            List<string[]> importedData = new List<string[]>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV / Json | *.txt;*.csv;*.json";
            openFileDialog.InitialDirectory = @"C:\Users\S00173244\Source\Repos\FOOP2CA1\CA1\CA1\bin";
            Nullable<bool> result =    openFileDialog.ShowDialog();

            if (result == true)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                if (openFileDialog.FileName.Contains(".csv")) { 
                
                    string temp = "";
                    while((temp = sr.ReadLine()) != null){
                        importedData.Add(temp.Split(';'));
                    }
                    return importedData;
                }
            }

            return importedData;
        }

        public List<Vehicle> ConvertCSVImportedDataToVehicleList(List<string[]> importedData)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

            foreach (string[] item in importedData)
            {
                if(item[0] == "Car")
                {
                    Car car = new Car(item[1], item[2], decimal.Parse(item[3]), int.Parse(item[4]), item[5], decimal.Parse(item[6]), item[7], new BitmapImage(new Uri(item[8])),(Car.CarBodyType) Enum.Parse(typeof(Car.CarBodyType),item[9]));
                }else if(item[0] == "Bike")
                {

                }else if (item[0] == "Van"){

                }
            }

            return vehicleList;
        }

        public bool ExportData(List<Vehicle> vehicleList)
        {

            foreach (Vehicle item in vehicleList)
            {
               

                
            }

            return true;
        }
    }
}
