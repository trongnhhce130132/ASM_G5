using System;
using System.Collections.Generic;

namespace ASMLibrary.DataAccess
{
    public partial class DonHang
    {
        public DonHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        public string IddonHang { get; set; } = null!;
        public string? Idkh { get; set; }
        public string? Diachi { get; set; }
        public string? Sdt { get; set; }
        public DateTime? ThoiGian { get; set; }
        public decimal? TongTien { get; set; }
        public int? Tt { get; set; }

        public virtual KhachHang? IdkhNavigation { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
