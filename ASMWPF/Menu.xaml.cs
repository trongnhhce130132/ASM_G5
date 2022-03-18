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
    /// Interaction logic for Memu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        MonAnService monAnService = new MonAnService(); 
        public List<MenuItem> menuItem = new List<MenuItem>();
        public Menu()
        {
            InitializeComponent();  
            lvmenu.ItemsSource = menuItem;
        }

        public List<MenuItem> GetItems()
        {
            var mon = monAnService.GetMonAns().ToList();
            foreach(var item in mon)
            {
                menuItem.Add(new MenuItem{ Id = item.Idmon, Title = item.TenMon, Price = item.DonGia, ImageData = LoadImage(@item.Hinh) });
                menuItem.Add(new MenuItem { Id = "s", Title = "aa", Price = 2000, ImageData = LoadImage(@"D:\anh.png") });

            }
            return menuItem;
        }
       

        private BitmapImage LoadImage(string filename)
        {
            return new BitmapImage(new Uri(filename));
        }
    }
}
