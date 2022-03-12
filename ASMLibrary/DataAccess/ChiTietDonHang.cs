using System;
using System.Collections.Generic;

namespace ASMLibrary.DataAccess
{
    public partial class ChiTietDonHang
    {
        public string Idctdh { get; set; } = null!;
        public string Idmon { get; set; } = null!;
        public string IddonHang { get; set; } = null!;
        public decimal? DonGia { get; set; }
        public int? SoLuong { get; set; }
        public int? Tt { get; set; }

        public virtual DonHang IddonHangNavigation { get; set; } = null!;
        public virtual MonAn IdmonNavigation { get; set; } = null!;
    }
}
