using System;
using System.Collections.Generic;

namespace ASMLibrary.DataAccess
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            Comments = new HashSet<Comment>();
            DonHangs = new HashSet<DonHang>();
            GioHangs = new HashSet<GioHang>();
        }

        public string Idkh { get; set; } = null!;
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? HotenKh { get; set; }
        public string? DiachiKh { get; set; }
        public string? Sdtkh { get; set; }
        public string? MailKh { get; set; }
        public int? Tt { get; set; }
        public string? Role { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual ICollection<GioHang> GioHangs { get; set; }
    }
}
