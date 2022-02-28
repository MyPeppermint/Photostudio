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

namespace _5Pr.Windows
{
    /// <summary>
    /// Логика взаимодействия для Nas.xaml
    /// </summary>
    public partial class Nas : Window
    {
        int ID_client;
        public Nas(string e, int ID_client)
        {
            InitializeComponent();
            this.ID_client = ID_client;
            er = e;
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

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Auto auto = new Auto();
            auto.Show();
            this.Close();
        }
    }
}
