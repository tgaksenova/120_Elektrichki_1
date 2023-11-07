using System;
using System.Collections.Generic;
using System.IO.Ports;
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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public class ticket123
    {
        public int ticket_id { get; set; }
        //public DateTime date { get; set; }
        //public DateTime time { get; set; }
        public int id_price_cat { get; set; }
        public int id_direction { get; set; }
        public string start_station { get; set; }
        public string end_station { get; set; }
        public int price { get; set; }
        public int id_person { get; set; }
    }
    public partial class Window3 : Window
    {
         
        public Window3()
        {
            InitializeComponent();

            shibuya1Entities2 db = new shibuya1Entities2();
            Usergrid.ItemsSource = db.ticket.ToList();
            //db.Dispose();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window zxc = new Window5();
            zxc.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            shibuya1Entities2 db = new shibuya1Entities2();
            string b = cat.Text;
            int categori =1;
            if (b == "Бизнесс")
            {
                categori = 1;
            }
            if (b =="Эконом")
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
            if(b =="В багажнике")
            {
                categori = 5;
            }
            Usergrid.ItemsSource = db.ticket.Where(x => x.id_price_cat == categori).ToList();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var temp = (ticket)Usergrid.SelectedItem;
            Application.Current.Properties["zxc"] = temp.ticket_id;
            Window5 a = new Window5();
            a.Show();
            this.Close();
        }
    }
}
