using System;
using System.Collections.Generic;

namespace ASMLibrary.DataAccess
{
    public partial class Comment
    {
        public string Idcomment { get; set; } = null!;
        public string Idkh { get; set; } = null!;
        public string Idmon { get; set; } = null!;
        public int? Rate { get; set; }
        public string? Comment1 { get; set; }
        public int? Tt { get; set; }

        public virtual KhachHang IdkhNavigation { get; set; } = null!;
        public virtual MonAn IdmonNavigation { get; set; } = null!;
    }
}
