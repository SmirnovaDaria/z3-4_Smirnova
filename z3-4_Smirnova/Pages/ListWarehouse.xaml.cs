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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace z3_4_Smirnova.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListWarehouse.xaml
    /// </summary>
    public partial class ListWarehouse : Page
    {
        public ListWarehouse()
        {
            InitializeComponent();
            var data = Entities.GetContext().Warehouse.ToList();
            ListViewWarehouse.ItemsSource = data;
        }

        private void AddWarehouse(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrameWindow.Content = new Pages.AddExitPage();
        }

        private void ExitWarehouse(object sender, MouseButtonEventArgs e)
        {
            MainWindow.MainFrameWindow.Content = new Pages.AddExitPage();
        }
    }
}
