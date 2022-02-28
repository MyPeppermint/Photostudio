using _5Pr.Windows;
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

namespace _5Pr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhotoEntities db = new PhotoEntities();
        Location location = new Location();
        int ID_client;
        int loc = 0;
        List<Location> locations = new List<Location>();
        public MainWindow(string e, int ID_client)
        {
            this.ID_client = ID_client;
            InitializeComponent();
            er = e;

            foreach (var location in db.Location)
            {
                locations.Add(location);
               
            }
            Loc.Text = locations[0].Loc;
            Style.Text = locations[0].Style;
            Sq.Text = locations[0].Square;
            Pr.Text = locations[0].Price;
        }
        string er;
       
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(er, ID_client);
            mainWindow.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Photo photo = new Photo(er, ID_client);
            photo.Show();
            this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Nas nas = new Nas(er, ID_client);
            nas.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            loc++;
            if (loc > 2)
                loc = 0;
            var converter = new ImageSourceConverter();
            switch (loc) 
            {
                case 0:
                    nameL.Source = (ImageSource)converter.ConvertFromString("pack://application:,,,/Resources/loc.jpg");
                    Loc.Text = locations[loc].Loc;
                    Style.Text = locations[loc].Style;
                    Sq.Text = locations[loc].Square;
                    Pr.Text = locations[loc].Price;
                    break;
                case 1:
                    nameL.Source = (ImageSource)converter.ConvertFromString("pack://application:,,,/Resources/loc2.jpg");
                    Loc.Text = locations[loc].Loc;
                    Style.Text = locations[loc].Style;
                    Sq.Text = locations[loc].Square;
                    Pr.Text = locations[loc].Price;
                    break;
                case 2:
                    nameL.Source = (ImageSource)converter.ConvertFromString("pack://application:,,,/Resources/loc3.jpg");
                    Loc.Text = locations[loc].Loc;
                    Style.Text = locations[loc].Style;
                    Sq.Text = locations[loc].Square;
                    Pr.Text = locations[loc].Price;
                    break;
                default:
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            loc--;
            if (loc < 0)
                loc = 2;
            var converter = new ImageSourceConverter();
            switch (loc)
            {
                case 0:
                    nameL.Source = (ImageSource)converter.ConvertFromString("pack://application:,,,/Resources/loc.jpg");
                    Loc.Text = locations[loc].Loc;
                    Style.Text = locations[loc].Style;
                    Sq.Text = locations[loc].Square;
                    Pr.Text = locations[loc].Price;
                    break;
                case 1:
                    nameL.Source = (ImageSource)converter.ConvertFromString("pack://application:,,,/Resources/loc2.jpg");
                    Loc.Text = locations[loc].Loc;
                    Style.Text = locations[loc].Style;
                    Sq.Text = locations[loc].Square;
                    Pr.Text = locations[loc].Price;
                    break;
                case 2:
                    nameL.Source = (ImageSource)converter.ConvertFromString("pack://application:,,,/Resources/loc3.jpg");
                    Loc.Text = locations[loc].Loc;
                    Style.Text = locations[loc].Style;
                    Sq.Text = locations[loc].Square;
                    Pr.Text = locations[loc].Price;
                    break;
                default:
                    break;
            }
        }

        private void red1_Click(object sender, RoutedEventArgs e)
        {
            MWEdit mWEdit = new MWEdit(er, ID_client);
            mWEdit.Show();
            this.Close();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Auto auto = new Auto();
            auto.Show();
            this.Close();
        }
    }
}
