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
    /// Interaction logic for CartForm.xaml
    /// </summary>
    public partial class CartForm : Window
    {
        private GioHangService gioHangService = new GioHangService();
        private MonAnService monAnService = new MonAnService();
        private ChiTietDonHangService chiTietDonHangService = new ChiTietDonHangService();
        private DonHangService donHangService = new DonHangService();
        public KhachHang khachHang;
        List<GioHang> gioHangs;
        public CartForm(KhachHang khach)
        {
            InitializeComponent();
            khachHang = khach;
            Loaddata();
        }
        public void Loaddata()
        {
            
            gioHangs =  gioHangService.GetGioHangByIDKhachHang(khachHang.Idkh).ToList();
            decimal? gia = 0;
            List<CartData> carts = new List<CartData>();
            foreach(GioHang g in gioHangs)
            {
                carts.Add(new CartData { Id = g.Idmon, Name=monAnService.GetMonAnByID(g.Idmon).TenMon , Soluong=g.SoLuong, Price =  (int)g.DonGia+"VND" });
                gia += g.DonGia*g.SoLuong;
            }
            lvCart.ItemsSource = carts;
            lbgia.Content =(int)gia+"VND";
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            UserForm user = new UserForm(khachHang);
            user.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            HomePageForm home = new HomePageForm(khachHang);
            home.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void lvCart_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lvCart.SelectedIndex != -1)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure?", "Delete food Confirmation", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    try
                    {
                        GioHang gio = gioHangs[lvCart.SelectedIndex];

                        gioHangService.DeleteGioHang(gio);
                        Loaddata();
                        MessageBox.Show("Delete Info Success!!");
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Do you want to order?", "Order food Confirmation", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                try
                {
                    DonHang don = new DonHang();
                    don.IddonHang = donHangService.GetIDCuoi();
                    don.Idkh = khachHang.Idkh;
                    don.Tt = 0;
                    donHangService.AddDonHang(don);
                    foreach (GioHang g in gioHangs)
                    {
                        ChiTietDonHang ctDon = new ChiTietDonHang();
                        ctDon.Idctdh = chiTietDonHangService.GetIDCuoi();
                        ctDon.IddonHang = don.IddonHang;
                        ctDon.Idmon = g.Idmon;
                        ctDon.SoLuong = g.SoLuong;
                        ctDon.DonGia = g.DonGia;
                        ctDon.Tt = 1;
                        chiTietDonHangService.AddChiTietDonHang(ctDon);
                    }
                    OrderForm orderForm = new OrderForm(khachHang, don);
                    orderForm.Show();
                    this.Close();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }

    public class CartData
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
