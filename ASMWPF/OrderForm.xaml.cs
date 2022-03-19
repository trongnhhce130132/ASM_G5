using ASMLibrary.DataAccess;
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
    /// Interaction logic for OrderForm.xaml
    /// </summary>
    public partial class OrderForm : Window
    {

        private MonAnService monAnService = new MonAnService();
        private ChiTietDonHangService chiTietDonHangService = new ChiTietDonHangService();
        private DonHangService donHangService = new DonHangService();
        public KhachHang khachHang;
        public DonHang donHang;
        decimal? gia = 0;
        List<ChiTietDonHang> chiTietDons;
        public OrderForm(KhachHang khach, DonHang don)
        {
            InitializeComponent();
            khachHang = khach;
            donHang = don;
            txtAddress.Text = khachHang.DiachiKh;
            txtPhone.Text = khachHang.Sdtkh;
            Loaddata();
        }

        public void Loaddata()
        {

            chiTietDons = chiTietDonHangService.GetChiTietDonHangByIDDonHang(donHang.IddonHang).ToList();
           
            
            List<CartData> carts = new List<CartData>();
            foreach (ChiTietDonHang g in chiTietDons)
            {
                carts.Add(new CartData { Id = g.Idmon, Name = monAnService.GetMonAnByID(g.Idmon).TenMon, Soluong = g.SoLuong, Price = (int)g.DonGia + "VND" });
                gia += g.DonGia * g.SoLuong;
            }
            lvOrder.ItemsSource = carts;
            lbgia.Content = (int)gia + "VND";
        }

       

        private void lvOrder_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lvOrder.SelectedIndex != -1)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure?", "Delete food Confirmation", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    try
                    {
                        ChiTietDonHang ctdon = chiTietDons[lvOrder.SelectedIndex];

                        chiTietDonHangService.DeleteChiTietDonHang(ctdon);
                       
                        MessageBox.Show("Delete Info Success!!");
                        Loaddata();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm(khachHang);
            homePageForm.Show();
            this.Close();

        }

       

        private void btnorder_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Do you want to order?", "Order food Confirmation", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                try
                {
                    var now = DateTime.Now;
         

                    donHang.Diachi = txtAddress.Text;
                    donHang.Sdt = txtPhone.Text;
                    donHang.TongTien = gia;
                    donHang.Tt = 1;
                    donHang.ThoiGian = now;
                    donHangService.UpdateDonHang(donHang);

                    MessageBox.Show("You onder Success!!");

                    HomePageForm homePageForm = new HomePageForm(khachHang);
                    homePageForm.Show();
                    this.Close();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }






    public class OrderData
    {
        private string _Id;
        private string _Name;
        private int? _Soluong;
        private string _Price;

        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int? Soluong
        {
            get { return _Soluong; }
            set { _Soluong = value; }
        }
        public string Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
    }
}
