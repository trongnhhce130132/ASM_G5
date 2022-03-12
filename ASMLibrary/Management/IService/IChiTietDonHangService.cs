using ASMLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.Management.IService
{
    public interface IChiTietDonHangService
    {
        IEnumerable<ChiTietDonHang> GetChiTietDonHangList();
        String GetIDCuoi();
        IEnumerable<ChiTietDonHang> GetChiTietDonHangByIDDonHang(String id);
        ChiTietDonHang GetChiTietDonHangByID(String id);
        void AddChiTietDonHang(ChiTietDonHang chiTietDonHang);
        void UpdateChiTietDonHang(ChiTietDonHang chiTietDonHang);
        void DeleteChiTietDonHang(ChiTietDonHang chiTietDonHang);
    }
}
