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
    /// Логика взаимодействия для Record.xaml
    /// </summary>
    public partial class Record : Window
    {
        PhotoEntities db = new PhotoEntities();
        RPh rPh = new RPh();

        public int getIdLoc(string name)
        {
            foreach (var item in db.Location)
            {
                if (item.Loc == name)
                {
                    return item.ID_loc;
                }
            }
            return 0;
        }
        public Record(string e, int ID_photo, int ID_client)
        {
            InitializeComponent();
            this.ID_photo = ID_photo;
            this.ID_client = ID_client;
            er = e;
           
        }
        string er;
        int ID_photo;
        int ID_client;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Combo.Text != "" && DateT.Text != "")
            {
                rPh.ID_client = ID_client;
                rPh.ID_photog = ID_photo;
                rPh.ID_loc = getIdLoc(Combo.Text);
                rPh.Loc = Combo.Text.Trim();
                rPh.Datetime = Convert.ToDateTime(DateT.Text);
                db.RPh.Add(rPh);
                db.SaveChanges();
                MessageBox.Show("Запись успешно выполнена");
            }
            else
            {
                MessageBox.Show("Не все данные были введены!", "Ошибка");
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Auto auto = new Auto();
            auto.Show();
            this.Close();
        }
    }
}

