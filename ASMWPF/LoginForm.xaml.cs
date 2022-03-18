using ASMLibrary.DataAccess;
using ASMLibrary.Management.IService;
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
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        private KhachHangSevice khachHangSevice = new KhachHangSevice();
        private KhachHang khachHang;
      //  IMonAnService monAn;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password.ToString();

            khachHang = khachHangSevice.CheckLogin(username, password);

            if(khachHang != null)
            {
                MessageBox.Show("dung oi");
                if (khachHang.Role.Equals("User"))
                {
                    Menu monAn = new Menu();
                 //   monAn.khach = khachHang;
                    monAn.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("sai oi");
            }
            
        }

        private void lbRegister_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RegisterForm  register = new RegisterForm();
            register.Show();
            this.Close();
        }
    }
}
