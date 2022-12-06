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
    /// Логика взаимодействия для AddExitPage.xaml
    /// </summary>
    public partial class AddExitPage : Page
    {
        public AddExitPage()
        {
            InitializeComponent();
        }

        private void BackPage(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrameWindow.Content = new Pages.ListWarehouse();
        }
    }
}
