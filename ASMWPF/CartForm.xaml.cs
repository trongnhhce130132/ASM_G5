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
        public CartForm()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            //UserForm user = new UserForm();
            //user.Show();
            //this.Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            //HomePageForm home = new HomePageForm();
            //home.Show();
            //this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
