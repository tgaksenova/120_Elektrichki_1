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

namespace zxcshibuya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text == "" || pass.Password.ToString() == "")
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            using (var db = new shibuya1Entities2())
            {
                string password = pass.Password.ToString();
                var logpass = db.logpass
                    .AsNoTracking()
                    .FirstOrDefault(u => u.login == login.Text && u.pass == password);
                if (logpass == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return;
                }
                else
                {
                    App.Current.Properties["currentuser"] = logpass.id_person;
                    MessageBox.Show("Успешный вход!");

                    if (Convert.ToInt32(logpass.Id_role) == 1)
                    {

                        Window6 zxc = new Window6();
                        zxc.Show();
                        this.Close();
                        return;
                    }
                    else
                            {
                        Window3 zxc = new Window3();
                        zxc.Show();
                        this.Close();
                        return;
                    }
                }
            }
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
     
            Window1 zxc = new Window1();
            zxc.Show();
            this.Close();
        }
    }
}
