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
    /// Логика взаимодействия для Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        public Window10()
        {
            
            InitializeComponent();
            shibuya1Entities2 db = new shibuya1Entities2();
            int zxc1 = Convert.ToInt32(Application.Current.Properties["zxc"]);
            napravlenie.Text = Convert.ToString(Application.Current.Properties["fio"]);
            nomer.Text = zxc1.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
