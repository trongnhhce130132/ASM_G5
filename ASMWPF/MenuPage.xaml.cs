using ASMLibrary.DataAccess;
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

namespace ASMWPF
{
    /// <summary>
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public List<MonAn> monAns = new List<MonAn>();
        public String monAn;
        public MenuPage()
        {
            InitializeComponent();

            load();
        }
        private void load()
        {

            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
if (monAn != null)
            {
                Uri fileUri = new Uri(monAn);
                img1.Source = new BitmapImage(fileUri);
                //  txtimg1.Content = "giá:" + monAn.DonGia;
            }
            else
            {
                txtimg1.Content = "giá: null";
            }
        }
    }
}
