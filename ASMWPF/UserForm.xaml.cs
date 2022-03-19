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
    /// Interaction logic for UserForm.xaml
    /// </summary>
    public partial class UserForm : Window
    {
        private KhachHangSevice khachHangSevice = new KhachHangSevice();
        public KhachHang khachHang;
        public UserForm(KhachHang khach)
        {
            InitializeComponent();
            khachHang = khach;
            loaddata();
        }

        public void loaddata()
        {
            lbUserName.Content = khachHang.Username;
            txtMail.Text = khachHang.MailKh;
            txtPhone.Text = khachHang.Sdtkh;
            txtAddress.Text = khachHang.DiachiKh;
        }


        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            HomePageForm home = new HomePageForm(khachHang);
            home.Show();
            this.Close();
        }

        private void btnCart_Click(object sender, RoutedEventArgs e)
        {
            CartForm cart = new CartForm();
            cart.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            khachHang.MailKh = txtMail.Text.ToString();
            khachHang.Sdtkh = txtPhone.Text.ToString();
            khachHang.DiachiKh = txtAddress.Text.ToString();

            MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure?", "Save Info Confirmation", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                try
                {
                    khachHangSevice.UpdateKhachHang(khachHang);
                    MessageBox.Show("Update Info Success!!");
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        void CheckText()
        {

        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}