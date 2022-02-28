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
    /// Логика взаимодействия для PhotoEdit.xaml
    /// </summary>
    public partial class PhotoEdit : Window
    {
        PhotoEntities db = new PhotoEntities();
        Photographer photographer = new Photographer();
        int ID_client;
        public PhotoEdit(string e, int ID_client)
        {
            InitializeComponent();
            this.ID_client = ID_client;
            er = e;
        }
        string er;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (id.Text != "")
            {
                UA.id = Convert.ToInt32(id.Text);
                foreach (var user in db.Photographer)
                {
                    if (user.ID_photog == UA.id)
                    {
                        photographer = user;
                        break;
                    }
                }
                if (name.Text != "" && pr.Text != "" && st.Text != "")
                {
                    photographer.Name = name.Text;
                    photographer.Price = pr.Text;
                    photographer.Exp = st.Text;
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
            Photo photo = new Photo(er, ID_client);
            photo.Show();
            this.Close();

        }
    }
}
