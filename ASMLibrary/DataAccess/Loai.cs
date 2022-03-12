using System;
using System.Collections.Generic;

namespace ASMLibrary.DataAccess
{
    public partial class Loai
    {
        public Loai()
        {
            MonAns = new HashSet<MonAn>();
        }

        public string Idloai { get; set; } = null!;
        public string? TenLoai { get; set; }

        public virtual ICollection<MonAn> MonAns { get; set; }
    }
}
