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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        Client client = new Client();
        Admin admin = new Admin();
        PhotoEntities db = new PhotoEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            if (FN.Text != "" && L.Text != "" && P.Text != "")
            {
                foreach (var user in db.Admin)
                {
                    if (user.Login == L.Text)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка");
                        n = 1;
                        return;
                    }
                }
                foreach (var user in db.Client)
                {
                    if (user.Login == L.Text)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка");
                        n = 1;
                        return;
                    }
                }
                if (n == 0)
                {
                    client.Nickname = FN.Text.Trim();
                    client.Login = L.Text.Trim();
                    client.Pass = P.Text.Trim();
                    db.Client.Add(client);
                    db.SaveChanges();

                    Auto auto = new Auto();
                    auto.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Не все данные были введены!", "Ошибка");
            }
        

        
    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Auto auto = new Auto();
            auto.Show();
            this.Close();

        }
    }
}
