﻿using ASMLibrary.DataAccess;
using ASMLibrary.Management.Sevice;
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

namespace ASMWPF
{
    /// <summary>
    /// Interaction logic for DetailsForm.xaml
    /// </summary>
    public partial class DetailsForm : Window
    {
        private GioHangService GioHangService = new GioHangService();
        public KhachHang khachHang;
        public MonAn monAn;
        public GioHang checkupdate;
        public DetailsForm(MonAn monan, KhachHang khach, GioHang gio)
        {
            InitializeComponent();
            monAn = monan;
            khachHang = khach;
            checkupdate = gio;
            loaddata();
        }
        public void loaddata()
        {
            if (monAn != null)
            {
                lbName.Content = monAn.TenMon.ToString();
                lbMT.Content = monAn.ChuThich.ToString();
                lbPrice.Content = "Giá: " + monAn.DonGia.ToString();
                Uri fileUri = new Uri(monAn.Hinh);
                imgdetail.Source = new BitmapImage(fileUri);
                if (checkupdate != null)
                {
                    txtSL.Text = "" + checkupdate.SoLuong;
                    btnadd.Content = "Update";
                }
            }
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            if (checkupdate != null)
            {
                CartForm cartForm = new CartForm(khachHang);
                cartForm.Show();
                this.Close();
            }
            else
            {
                HomePageForm homePage = new HomePageForm(khachHang);
                homePage.Show();
                this.Close();
            }

        }

        private void btndown_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(txtSL.Text) > 1)
            {
                txtSL.Text = Convert.ToString(Convert.ToInt32(txtSL.Text) - 1);
            }
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            if (btnadd.Content.Equals("Add to cart"))
            {
                try
                {
                    GioHang gio = GioHangService.GetGioHangList().FirstOrDefault(g => g.Idkh.Equals(khachHang.Idkh) && g.Idmon.Equals(monAn.Idmon));
                    if (gio != null)
                    {
                        gio.SoLuong = gio.SoLuong + Convert.ToInt32(txtSL.Text);
                        GioHangService.UpdateGioHang(gio);
                    }
                    else
                    {

                        GioHang gioHang = new GioHang()
                        {
                            IdgioHang = GioHangService.GetIDCuoi(),
                            Idkh = khachHang.Idkh,
                            Idmon = monAn.Idmon,
                            DonGia = monAn.DonGia,
                            SoLuong = Convert.ToInt32(txtSL.Text)
                        };

                        GioHangService.AddGioHang(gioHang);
                    }
                    MessageBox.Show("Add to cart success!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else if (btnadd.Content.Equals("Update"))
            {
                try
                {
                    GioHang gio = GioHangService.GetGioHangList().FirstOrDefault(g => g.Idkh.Equals(khachHang.Idkh) && g.Idmon.Equals(monAn.Idmon));
                    if (gio != null)
                    {
                        gio.SoLuong = Convert.ToInt32(txtSL.Text);
                        GioHangService.UpdateGioHang(gio);
                        MessageBox.Show("Update quantity of cart success!!");
                    }
                    CartForm cartForm = new CartForm(khachHang);
                    cartForm.Show();
                    this.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnup_Click(object sender, RoutedEventArgs e)
        {
            txtSL.Text = Convert.ToString(Convert.ToInt32(txtSL.Text) + 1);
        }
    }
}
