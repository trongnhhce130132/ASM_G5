using System;
using System.Collections.Generic;

namespace ASMLibrary.DataAccess
{
    public partial class MonAn
    {
        public MonAn()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            Comments = new HashSet<Comment>();
            GioHangs = new HashSet<GioHang>();
        }

        public string Idmon { get; set; } = null!;
        public string? TenMon { get; set; }
        public string? Hinh { get; set; }
        public string? Idloai { get; set; }
        public decimal? DonGia { get; set; }
        public string? ChuThich { get; set; }
        public int? Rate { get; set; }
        public int? Tt { get; set; }

        public virtual Loai? IdloaiNavigation { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<GioHang> GioHangs { get; set; }
    }
}
