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
using ONDE1.Models;
namespace ONDE1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Window_Loader(object sender,RoutedEventArgs e)
        {
            QLBenhNhanContext db = new QLBenhNhanContext();
            var query1 = from bn in db.BenhNhans                       
                        group bn
                        by bn.Makhoa into spGroup
                        select new
                        {
                         MaKhoa = spGroup.Key,
                         TongVienPhi = spGroup.Sum(t=>t.SongayNv*60000)
                        };
            var query2 = from t in query1
                         join kk in db.KhoaKhams
                         on t.MaKhoa equals kk.Makhoa
                         select new
                         {
                             kk.Makhoa,
                             kk.Tenkhoa,
                             t.TongVienPhi
                         };
            dgvThongKe.ItemsSource = query2.ToList();
        }
    }
}
