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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public class ticket123
        {
            public int ticket_id { get; set; }
            public DateTime date { get; set; }
            public DateTime time { get; set; }
            public int id_price_cat { get; set; }
            public int id_direction { get; set; }
            public string start_station { get; set; }
            public string end_station { get; set; }
            public int price { get; set; }
            public int id_person { get; set; }
        }
        public Window5()
        {
            InitializeComponent();
            shibuya1Entities2 db = new shibuya1Entities2();
            int zxc1 = Convert.ToInt32(Application.Current.Properties["zxc"]);
            napravlenie.Text = db.ticket.Where(x=>x.ticket_id == zxc1).Select(x=>x.end_station).First().ToString();
            nomer.Text = zxc1.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
