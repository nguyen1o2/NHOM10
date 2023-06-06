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
using ONTAP3.Models;
using System.Reflection;
namespace ONTAP3
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
        QLBHContext db = new QLBHContext();

        private void HienThiDuLieu()
        {
            var query = from sp in db.SanPhams
                        orderby sp.DonGia
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.SoLuong,
                            sp.DonGia,
                            ThanhTien = sp.DonGia * sp.SoLuong
                        };
            dgvSanPham.ItemsSource = query.ToList();
        }

        private void HienThiCB()
        {
            var query = from lsp in db.LoaiSanPhams
                        select lsp;
            cboloaiSP.ItemsSource = query.ToList();
            cboloaiSP.DisplayMemberPath = "TenLoai";
            cboloaiSP.SelectedValuePath = "MaLoai";
            cboloaiSP.SelectedIndex = 0;
        }

        private void Window_Loaded(object sender,RoutedEventArgs e)
        {
            HienThiDuLieu();
            HienThiCB();
        }

        private void btnthem_Click(object sender, RoutedEventArgs e)
        {
            var query = (from sp in db.SanPhams
                         where sp.MaSp == txtmaSP.Text
                         select sp).SingleOrDefault();
            if (query != null)
            {
                MessageBox.Show("Ma san pham da ton tai", "Thong bao");
                HienThiDuLieu();
            }
            else
            {
                SanPham spmoi = new SanPham();
                spmoi.MaSp = txtmaSP.Text;
                spmoi.TenSp = txttenSP.Text;
                spmoi.SoLuong = int.Parse(txtsoLuong.Text);
                spmoi.DonGia = float.Parse(txtdonGia.Text);
                LoaiSanPham s = (LoaiSanPham)cboloaiSP.SelectedItem;
                spmoi.MaLoai = s.MaLoai;
                db.SanPhams.Add(spmoi);
                db.SaveChanges();
                MessageBox.Show("Them thanh cong", "Thong bao");
                HienThiDuLieu();
            }
        }

        private void btnsua_Click(object sender, RoutedEventArgs e)
        {
            /*var spsua = (from sp in db.SanPhams
                         where sp.MaSp == txtmaSP.Text
                         select sp).SingleOrDefault();*/
            var spsua = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtmaSP.Text));
            if (spsua != null)
            {
                spsua.TenSp = txttenSP.Text;
                spsua.SoLuong = int.Parse(txtsoLuong.Text);
                spsua.DonGia = float.Parse(txtdonGia.Text);
                LoaiSanPham s = (LoaiSanPham)cboloaiSP.SelectedItem;
                spsua.MaLoai = s.MaLoai;
                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Ma san pham khong ton tai", "Thong bao");
            }          
        }

        private void btnxoa_Click(object sender, RoutedEventArgs e)
        {
            var spxoa = db.SanPhams.SingleOrDefault(t => t.MaSp.Equals(txtmaSP.Text));
            if(spxoa == null)
            {
                MessageBox.Show("Ma san pham khong ton tai", "thong bao");
            }
            else
            {
                db.SanPhams.Remove(spxoa);
                db.SaveChanges();
                MessageBox.Show("Xoa thanh cong", "Thong bao");
                HienThiDuLieu();
            }
        }

        private void btnthongke_Click(object sender, RoutedEventArgs e)
        {
            Window mywindow = new Window();
            mywindow.Show();
        }

        private void dgvSanPham_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dgvSanPham.SelectedItem != null)
            {
                try
                {
                    Type t = dgvSanPham.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtmaSP.Text = p[0].GetValue(dgvSanPham.SelectedValue).ToString();
                    txttenSP.Text = p[1].GetValue(dgvSanPham.SelectedValue).ToString();
                    cboloaiSP.SelectedValue = p[2].GetValue(dgvSanPham.SelectedValue).ToString();
                    txtsoLuong.Text = p[3].GetValue(dgvSanPham.SelectedValue).ToString();
                    txtdonGia.Text = p[4].GetValue(dgvSanPham.SelectedValue).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Loi chon hang " + ex.Message, "Thong bao");
                }
            }
        }

        private void btntim_Click(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        where sp.MaSp == txtmaSP.Text
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.SoLuong,
                            sp.DonGia,
                            ThanhTien = sp.DonGia * sp.SoLuong
                        };
            dgvSanPham.ItemsSource = query.ToList();
        }
    }
}
