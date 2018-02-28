using CA1.Classes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CA1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Vehicle> allVehicles = new ObservableCollection<Vehicle>();
        protected ObservableCollection<Vehicle> dynamicCollectionOfVehicles = new ObservableCollection<Vehicle>();

        private List<string> sortOptions = new List<string>();

        public MainWindow()
        {
            
            InitializeComponent();
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            sortOptions.AddRange(new List<string> { "Price", "Mileage", "Make" });
            cbox_SortBy.ItemsSource = sortOptions;
            cbox_SortBy.SelectedIndex = 0;
        }
       

        private void rd_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rd_All.IsChecked)
            {
                dynamicCollectionOfVehicles = new ObservableCollection<Vehicle>(allVehicles);
            }else if((bool)rd_Bike.IsChecked)
            {
                dynamicCollectionOfVehicles = new ObservableCollection<Vehicle>(allVehicles.Where(b => b is Bike));
            }
            else if ((bool)rd_Car.IsChecked)
            {                
                dynamicCollectionOfVehicles = new ObservableCollection<Vehicle>(allVehicles.Where(b => b is Car));                
            }else if ((bool)rd_Van.IsChecked)
            {
                dynamicCollectionOfVehicles = new ObservableCollection<Vehicle>(allVehicles.Where(b => b is Van));
            }
        }

        private void cbox_SortBy_Selected(object sender, RoutedEventArgs e)
        {
           
            if (cbox_SortBy.SelectedItem != null)
            {
                if (cbox_SortBy.SelectedItem.ToString() == "Price")
                {
                    dynamicCollectionOfVehicles.OrderBy(o => o.Price);
                } else if (cbox_SortBy.SelectedItem.ToString() == "Mileage")
                {
                    dynamicCollectionOfVehicles.OrderBy(o => o.Mileage);
                } else if (cbox_SortBy.SelectedItem.ToString() == "Make")
                {
                    dynamicCollectionOfVehicles.OrderBy(o => o.Make);
                }
                
            }
        }

        private void lbox_vehicleList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lbox_vehicleList.SelectedItem!= null)
            {
                Vehicle tempVehicle = lbox_vehicleList.SelectedItem as Vehicle;
                lbl_DescriptionValue.Content = tempVehicle.Description;
                lbl_ColorValue.Content = tempVehicle.Color;
                lbl_MakeValue.Content = tempVehicle.Make;
                lbl_MileageValue.Content = tempVehicle.Mileage;
                lbl_ModelValue.Content = tempVehicle.Model;
                lbl_PriceValue.Content = tempVehicle.Price;
                lbl_YearValue.Content = tempVehicle.Year;
                img_Vehicle.Source = tempVehicle.Image;
                

            }
        }
        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            AddVehicleWindow addVehicle = new AddVehicleWindow();
            addVehicle.Owner = this;
            addVehicle.ShowDialog();
        }
        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            EditVehicleWindow editVehicle = new EditVehicleWindow();
            editVehicle.Owner = this;
            editVehicle.ShowDialog();
            
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            if(lbox_vehicleList.SelectedItem != null)
            {
                dynamicCollectionOfVehicles.Remove(lbox_vehicleList.SelectedItem as Vehicle);
            }
        }

        private void btn_Load_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
