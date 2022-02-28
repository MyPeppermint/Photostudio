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
    /// Логика взаимодействия для MWEdit.xaml
    /// </summary>
    public partial class MWEdit : Window
    {
        PhotoEntities db = new PhotoEntities();
        Location location = new Location();
        int ID_client;
        public MWEdit(string e, int ID_client)
        {
            this.ID_client = ID_client;
            InitializeComponent();
            er = e;
        }
        string er;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (id.Text != "")
            {
                UA.id = Convert.ToInt32(id.Text);
                foreach (var user in db.Location)
                {
                    if (user.ID_loc == UA.id)
                    {
                        location = user;
                        break;
                    }
                }
                if (sq.Text != "" && st.Text != "" && name.Text != "" && pr.Text != "")
                {
                    location.Square = sq.Text;
                    location.Style = st.Text;
                    location.Loc = name.Text;
                    location.Price = pr.Text;
                    db.SaveChanges();
                    MessageBox.Show("Изменения успешно применены!");
                }
                else
                {
                    MessageBox.Show("Некорректный ввод!");
                }
            }
            else
            {
                MessageBox.Show("Укажите ID");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(er, ID_client);
            mainWindow.Show();
            this.Close();

        }
    }
}
