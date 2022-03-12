using System;
using System.Collections.Generic;

namespace ASMLibrary.DataAccess
{
    public partial class GioHang
    {
        public string IdgioHang { get; set; } = null!;
        public string? Idkh { get; set; }
        public string? Idmon { get; set; }
        public decimal? DonGia { get; set; }
        public int? SoLuong { get; set; }

        public virtual KhachHang? IdkhNavigation { get; set; }
        public virtual MonAn? IdmonNavigation { get; set; }
    }
}
