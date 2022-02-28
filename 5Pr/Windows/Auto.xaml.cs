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
    /// Логика взаимодействия для Auto.xaml
    /// </summary>
    public partial class Auto : Window
    {
        public int getIdClient(string name)
        {
            foreach (var item in db.Client)
            {
                if (item.Login == name)
                {
                    return item.ID_client;
                }
            }
            return 0;
        }

        public int getIdAdmin(string name)
        {
            foreach (var item in db.Admin)
            {
                if (item.Login == name)
                {
                    return item.ID_admin;
                }
            }
            return 0;
        }
        public Auto()
        {
            InitializeComponent();
        }
        PhotoEntities db = new PhotoEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (L.Text != "" && P.Text != "")
            {
                if (db.Admin.Where(r => r.Login == L.Text && r.Pass == P.Text).Count() > 0)
                 {
                UA.ua = L.Text;
                MainWindow mainwindow = new MainWindow("Admin", getIdAdmin(L.Text));
                mainwindow.Show();
                this.Close();
                }

                else if (db.Client.Where(r => r.Login == L.Text && r.Pass == P.Text).Count() > 0)
                 {
                UA.ua = L.Text;
                MainWindow mainwindow = new MainWindow("Client", getIdClient(L.Text));
                mainwindow.Show();
                this.Close();
                    }

                else
                {
                    L.Text = "";
                    P.Text = "";
                    MessageBox.Show("Логин или пароль введены неверно");
                }
            }
            else
                {

                L.Text = "";
                P.Text = "";
                MessageBox.Show("Введите логин и пароль");

                }

}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
            this.Close();
        }
    }
}
