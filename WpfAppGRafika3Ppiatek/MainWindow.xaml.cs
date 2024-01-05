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
using static System.Net.Mime.MediaTypeNames;

namespace WpfAppGRafika3Ppiatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<BitmapImage> Images { get; set; }
        public int Aktualny { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Aktualny = 0;
            przygotujDane();
        }

        private void przygotujDane()
        {
            Images = new List<BitmapImage>();
            Images.Add(new BitmapImage(new Uri("rys1.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys2.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys3.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys4.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys5.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys6.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys7.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("rys8.jpg", UriKind.Relative)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Aktualny--;
            if(Aktualny < 0)
                Aktualny = Images.Count - 1;
            obrazek.Source = Images[Aktualny];
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Aktualny++;
            if (Aktualny == Images.Count)
                Aktualny = 0;
            obrazek.Source = Images[Aktualny];

        }

        private void nr_obrazka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int nr = (int)nr_obrazka.SelectedIndex;
            MessageBox.Show(nr.ToString());
            obrazek_cb.Source = Images[nr];
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            //sender as RadioButton;

            obrazek_radio.Source = new BitmapImage(new Uri("rys1.jpg", UriKind.Relative));
        }
    }
}
