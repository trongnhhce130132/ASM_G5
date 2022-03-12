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
    public class ChiTietDonHangService : IChiTietDonHangService
    {
        ChiTietDonHangDAO ChiTietDonHang = new ChiTietDonHangDAO();

        public IEnumerable<ChiTietDonHang> GetChiTietDonHangList() => ChiTietDonHang.GetChiTietDonHangList();
        public String GetIDCuoi() => ChiTietDonHang.GetIDCuoi();
        public IEnumerable<ChiTietDonHang> GetChiTietDonHangByIDDonHang(String id) => ChiTietDonHang.GetChiTietDonHangByIDDonHang(id);
        public ChiTietDonHang GetChiTietDonHangByID(String id) => ChiTietDonHang.GetChiTietDonHangByID(id);
        public void AddChiTietDonHang(ChiTietDonHang chiTietDonHang) => ChiTietDonHang.AddChiTietDonHang(chiTietDonHang);
        public void UpdateChiTietDonHang(ChiTietDonHang chiTietDonHang) => ChiTietDonHang.UpdateChiTietDonHang(chiTietDonHang);
        public void DeleteChiTietDonHang(ChiTietDonHang chiTietDonHang) => ChiTietDonHang.DeleteChiTietDonHang(chiTietDonHang);
    }
}
