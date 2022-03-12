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
    /// Interaction logic for LoaiForm.xaml
    /// </summary>
    public partial class LoaiForm : Window
    {
        LoaiService loaiService = new LoaiService();
        KhachHangSevice khachHangSevice =new KhachHangSevice();
        public LoaiForm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = khachHangSevice.GetKhachHangs().FirstOrDefault(a => a.Idkh.Equals("KH001")).Role;
        }
    }
}
