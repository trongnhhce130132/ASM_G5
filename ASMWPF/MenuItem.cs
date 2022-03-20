using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ASMWPF
{
    public class MenuItem
    {
        private string _Id;
        private string? _Name;
        private string? _Price;
        private BitmapImage _ImageData;
        public MenuItem() { 
        }
        public MenuItem(string id, string? name, string? price, BitmapImage imageData)
        {
            _Id = id;
            _Name = name;
            _Price = price;
            _ImageData = imageData;
        }
        public string? Name
        {
            get { return this._Name; }
            set { this._Name = value; }
        }
        public string? Price
        {
            get { return this._Price; }
            set { this._Price = value; }
        }
        public string Id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }

       
        public BitmapImage ImageData
        {
            get { return this._ImageData; }
            set { this._ImageData = value; }
        }
    }
}
