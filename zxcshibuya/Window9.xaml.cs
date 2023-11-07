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
    /// Логика взаимодействия для Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        public Window9()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            shibuya1Entities2 db = new shibuya1Entities2();
            logpass logpassObject = new logpass
            {
                login = login.Text,
                pass = pass.Text
            };
            db.logpass.Add(logpassObject);

            db.SaveChanges();
            db.Dispose();
        }
    }
}
