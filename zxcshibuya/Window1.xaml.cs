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

namespace zxcshibuya
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow zxc = new MainWindow();
            zxc.Show();
            this.Close();

            int flagpass = 1;
            string password = pass.Password.ToString();
            string log = login.Text;
            int flagcifr = 0;
            int flageng = 1;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57) flagcifr = 1;
                if ((password[i] >= 65 && password[i] <= 90) || (password[i] >= 97 && password[i] <= 122) || (password[i] >= 48 && password[i] <= 57)) continue;
                else
                {
                    flageng = 0;
                    break;
                }
            }
            if (flagcifr == 0 || flageng == 0 || password.Length < 6) flagpass = 0;
            if (flagpass == 0)
            {
                MessageBox.Show("Пароль введен в неверном формате. Пароль должен содержать 6 или более символов, состоять из английских букв и содержать хотя бы одну цифру.");
            }
            int flaglogin = 1;
            var db = new    shibuya1Entities2();
            var logpass = db.logpass
                .AsNoTracking()
                .FirstOrDefault(u => u.login == log);
            if (logpass == null)
            {
                flaglogin = 0;
            }
            else
            {
                MessageBox.Show("Пользователь с таким именем уже зарегистрирован!");
                return;
            }
            if (flaglogin == 0 && flagpass == 1)
            {
                MessageBox.Show("Успешная регистрация!");
            }

            //Tarasov_Zharkov_TRPOEntities db = new Tarasov_Zharkov_TRPOEntities();
            logpass logpassObject = new logpass
            {
                login = login.Text,
                pass = pass.Password.ToString()
            };
            db.logpass.Add(logpassObject);
            db.SaveChanges();
            db.Dispose();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           MainWindow mainWindow = new MainWindow();

            mainWindow.Show();
            this.Close();
        }
    }
}
