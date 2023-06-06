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
using ONDE1.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace ONDE1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        QLBenhNhanContext db = new QLBenhNhanContext();

        private void HienThiDuLieu()
        {
            var query = from bn in db.BenhNhans
                        where bn.SongayNv <= 20
                        orderby bn.SongayNv descending
                        select new
                        {
                          bn.Mabn,
                          bn.Hoten,
                          bn.Makhoa,
                          bn.Diachi,
                          bn.SongayNv,
                          VienPhi = bn.SongayNv*60000
                        };
            dgvBenhNhan.ItemsSource = query.ToList();
        }

        private void HienThiCB()
        {
            var query = from kk in db.KhoaKhams
                        select kk;
            cboKK.ItemsSource = query.ToList();
            cboKK.DisplayMemberPath = "Tenkhoa";
            cboKK.SelectedValuePath = "Makhoa";
            cboKK.SelectedIndex = 0;
        }

        private void Window_Loader(object sender , RoutedEventArgs e)
        {
            HienThiCB();
            HienThiDuLieu();
        }

        private bool CheckDL()
        {
            string tb = "";
            if (txtmaBN.Text == "" || txtHT.Text == "" || txtDC.Text =="" || txtSNNV.Text == "")
            {
                tb += "\nPhai nhap day du du lieu";
            }
            if (!Regex.IsMatch(txtSNNV.Text, @"\d+"))
            {
                tb += "\nSo ngay nam vien phai la so";
            }
            else
            {
                int sn = int.Parse(txtSNNV.Text);
                if (sn < 0)
                {
                    tb += "\nSo ngay nam viem phai la so nguyen";
                }
            }
            if (tb != "")
            {
                MessageBox.Show(tb, "Thong bao", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, RoutedEventArgs e)
        {
            var query = db.BenhNhans.SingleOrDefault(t => t.Mabn.Equals(txtmaBN.Text));
            if (query != null)
            {
                MessageBox.Show("Bi trung Mabn", "Thong bao");
                HienThiDuLieu();
            }
            else
            {
                if (CheckDL()) {
                try
                {
                    BenhNhan bnmoi = new BenhNhan();
                    bnmoi.Mabn = txtmaBN.Text;
                    bnmoi.Hoten = txtHT.Text;
                    bnmoi.Diachi = txtDC.Text;
                    bnmoi.SongayNv = int.Parse(txtSNNV.Text);
                    KhoaKham a = (KhoaKham)cboKK.SelectedItem;
                    bnmoi.Makhoa = a.Makhoa;
                    db.BenhNhans.Add(bnmoi);
                    db.SaveChanges();
                    MessageBox.Show("Them thanh cong", "Thong bao");
                    HienThiDuLieu();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Co loi khi them" + ex.Message, "Thong bao");
                }
                }
            }
        }

        private void dgvBenhNhan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (dgvBenhNhan.SelectedItem != null)
                {
                    Type t = dgvBenhNhan.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtmaBN.Text = p[0].GetValue(dgvBenhNhan.SelectedValue).ToString();
                    txtHT.Text = p[1].GetValue(dgvBenhNhan.SelectedValue).ToString();
                    cboKK.SelectedValue = p[2].GetValue(dgvBenhNhan.SelectedValue).ToString();
                    txtDC.Text = p[3].GetValue(dgvBenhNhan.SelectedValue).ToString();
                    txtSNNV.Text = p[4].GetValue(dgvBenhNhan.SelectedValue).ToString();
                }
            }
            catch(Exception ex1)
            {
                MessageBox.Show("Co loi " + ex1.Message, "Thong bao");
            }
        }

        private void btnsua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var spsua = db.BenhNhans.SingleOrDefault(t => t.Mabn.Equals(txtmaBN.Text));
                if (spsua == null)
                {
                    MessageBox.Show("Khong tim thay ma san pham sua", "Thong bao");
                }
                else
                {
                    if (CheckDL())
                    {
                        spsua.Hoten = txtHT.Text;                      
                        spsua.Diachi = txtDC.Text;
                        spsua.SongayNv = int.Parse(txtSNNV.Text);
                        KhoaKham a = (KhoaKham)cboKK.SelectedItem;
                        spsua.Makhoa = a.Makhoa;
                        db.SaveChanges();
                        HienThiDuLieu();
                    }
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Co loi khi sua", "Thong bao");
            }
        }

        private void btnxoa_Click(object sender, RoutedEventArgs e)
        {
            var spxoa = db.BenhNhans.SingleOrDefault(t => t.Mabn.Equals(txtmaBN.Text));
            if(spxoa != null)
            {
                MessageBoxResult rs = MessageBox.Show("ban co chan muon xoa khong", "Thong bao", MessageBoxButton.YesNo);
                if(rs == MessageBoxResult.Yes)
                {
                    db.BenhNhans.Remove(spxoa);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay mabn de xoa", "Thong bao");
            }
        }

        private void btnthongke_Click(object sender, RoutedEventArgs e)
        {
            Window1 mywin = new Window1();
            mywin.Show();
        }
    }
}
