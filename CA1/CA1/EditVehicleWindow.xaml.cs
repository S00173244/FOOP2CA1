using CA1.Classes;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace CA1
{
    /// <summary>
    /// Interaction logic for EditVehicleWindow.xaml
    /// </summary>
    public partial class EditVehicleWindow : Window
    {
        public EditVehicleWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Owner as MainWindow;

            if(mainWindow.lbox_vehicleList.SelectedItem is Bike)
            {
                var stackPanel = new StackPanel();
                stackPanel.Children.Add(new Label { Content = "A" });
                stackPanel.Children.Add(new Button { Content = "F" });
                this.Content = stackPanel;
            }
            else if (mainWindow.lbox_vehicleList.SelectedItem is Car)
            {

            }
            else if (mainWindow.lbox_vehicleList.SelectedItem is Van)
            {

            }
            
        }
    }
}
