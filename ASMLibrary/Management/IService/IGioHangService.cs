using ASMLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.Management.IService
{
    public interface IGioHangService
    {
        IEnumerable<GioHang> GetGioHangList();
        String GetIDCuoi();
        IEnumerable<GioHang> GetGioHangByIDKhachHang(string id);
        GioHang GetGioHangByID(string id);
        void AddGioHang(GioHang gioHang);
        void UpdateGioHang(GioHang gioHang);
        void DeleteGioHang(GioHang gioHang);
    }
}
