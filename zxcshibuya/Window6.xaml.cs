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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
            shibuya1Entities2 db = new shibuya1Entities2();
            Usergrid.ItemsSource = db.ticket.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window zxc = new Window4();
            zxc.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            shibuya1Entities2 db = new shibuya1Entities2();
            string b = cat.Text;
            int categori = 1;
            if (b == "Бизнесс")
            {
                categori = 1;
            }
            if (b == "Эконом")
            {
                categori = 2;
            }
            if (b == "Комфорт")
            {
                categori = 3;
            }
            if (b == "Комфорт+")
            {
                categori = 4;
            }
            if (b == "В багажнике")
            {
                categori = 5;
            }
            Usergrid.ItemsSource = db.ticket.Where(x => x.id_price_cat == categori).ToList();
        }
        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var temp = (ticket)Usergrid.SelectedItem;
            Application.Current.Properties["zxc"] = temp.ticket_id;
            Application.Current.Properties["fio"] = fioo.Text;
            Window10 a = new Window10();
            a.Show();
            this.Close();
        }
    }
}
