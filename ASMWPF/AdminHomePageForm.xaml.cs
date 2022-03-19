using ASMLibrary.DataAccess;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for AdminHomePageForm.xaml
    /// </summary>
    public partial class AdminHomePageForm : Window
    {
        public KhachHang admin;
        public AdminHomePageForm()
        {
            InitializeComponent();
            ClearErrorLabel();
        }

        void ClearErrorLabel()
        {
            lbNameError.Content = "";
            lbNoteError.Content = "";
            lbPriceError.Content = "";
            lbStatusError.Content = "";
            lbImg.Content = "";
        }


        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
                lbImg.Content = filename;
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            AdminUpdateForm update = new AdminUpdateForm();
            update.Show();
        }
    }
}
