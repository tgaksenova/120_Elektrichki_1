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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window9 taskwindow = new Window9();
            taskwindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window8 taskwindow = new Window8();
            taskwindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window7 taskwindow = new Window7();
            taskwindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            shibuya1Entities2 db = new shibuya1Entities2();
            UsersGrid.ItemsSource = db.logpass.ToList();
            db.Dispose();
        }
    }
}
