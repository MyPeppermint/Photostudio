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
using System.Windows.Shapes;

namespace _5Pr
{
    /// <summary>
    /// Логика взаимодействия для Photo.xaml
    /// </summary>
    public partial class Photo : Window
    {
            PhotoEntities db = new PhotoEntities();
             int ID_client;
        public int getIdPhotographer(string name)
        {
            foreach (var item in db.Photographer)
            {
                if(item.Name == name)
                {
                    return item.ID_photog;
                }
            }
            return 0;
        }
        public void feelcomboPhotographer()
        {
            foreach (var item in db.Photographer)
            {
                Photograf.Items.Add(item.Name);
            }
        }
        public Photo(string e, int ID_client)
        {
            Photographer photographer = new Photographer();
            InitializeComponent();
            this.ID_client = ID_client;
            feelcomboPhotographer();
            er = e;
            if (er == "Client")
            {
                red.Visibility = Visibility.Hidden;
            }
        }
        string er;

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow mainwindow = new MainWindow(er, ID_client);
            mainwindow.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //Photo photo = new Photo(er);
            //photo.Show();
            //this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Nas nas = new Nas(er, ID_client);
            nas.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Record record = new Record(er, getIdPhotographer(Photograf.Text), ID_client);
            record.Show();
            this.Close();
        }

        private void Photograf_DropDownClosed(object sender, EventArgs e)
        {
            foreach( var item in  db.Photographer)
            {
                if( item.Name == Photograf.Text)
                {
                    Pr.Text = item.Price;
                    Exp.Text = item.Exp;
                    break;
                }
            }
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            PhotoEdit photoEdit = new PhotoEdit(er, ID_client);
            photoEdit.Show();
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
