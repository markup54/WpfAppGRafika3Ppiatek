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

namespace WpfAppGRafika3Ppiatek
{
    /// <summary>
    /// Logika interakcji dla klasy Menu_ObrazkiWindow.xaml
    /// </summary>
    public partial class Menu_ObrazkiWindow : Window
    {
        public Menu_ObrazkiWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            obrazek_menu.Source = new BitmapImage(new Uri("rys2.jpg", UriKind.Relative));
        }
    }
}
