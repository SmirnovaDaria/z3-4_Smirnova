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

namespace z3_4_Smirnova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame MainFrameWindow;
        public MainWindow()
        {
            InitializeComponent();
            MainFrameWindow = MainFrame;
            MainFrameWindow.Content = new Pages.ListWarehouse();
        }

        private void NavigateMaterial(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Pages.BuildingMaterialPage();
        }

        private void NavigateWarsehouse(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Pages.ListWarehouse();
        }
    }
}
