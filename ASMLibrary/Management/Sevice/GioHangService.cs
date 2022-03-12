using ASMLibrary.DAO;
using ASMLibrary.DataAccess;
using ASMLibrary.Management.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.Management.Sevice
{
    public class GioHangService : IGioHangService
    {
        GioHangDAO GioHang = new GioHangDAO();

        public IEnumerable<GioHang> GetGioHangList() => GioHang.GetGioHangList();
        public String GetIDCuoi() => GioHang.GetIDCuoi();
        public IEnumerable<GioHang> GetGioHangByIDKhachHang(string id) => GioHang.GetGioHangByIDKhachHang(id);
        public GioHang GetGioHangByID(string id) => GioHang.GetGioHangByID(id);
        public void AddGioHang(GioHang gioHang) => GioHang.AddGioHang(gioHang);
        public void UpdateGioHang(GioHang gioHang) => GioHang.UpdateGioHang(gioHang);
        public void DeleteGioHang(GioHang gioHang) => GioHang.DeleteGioHang(gioHang);


    }
}
