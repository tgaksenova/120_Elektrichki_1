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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            shibuya1Entities2 db = new shibuya1Entities2();
            int temp_id = Convert.ToInt32(id.Text);
            try
            {
                foreach (var i in db.logpass)
                {
                    if (i.id_person == temp_id)
                    {
                        db.Entry(i).State = System.Data.Entity.EntityState.Deleted;
                        db.logpass.Remove(i);

                    }
                }
                db.SaveChanges();
                db.Dispose();
            }
            catch 
            {
                MessageBox.Show("Нельзя удалить пользователя с активным билетом!!!");
            }
        }
    }
}
