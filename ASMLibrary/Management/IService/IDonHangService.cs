using ASMLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.Management.IService
{
    public interface IDonHangService
    {
        IEnumerable<DonHang> GetDonHangList();
        IEnumerable<DonHang> GetDonHangByIDKhachHang(String id);
        DonHang GetDonHangByID(String id);
        String GetIDCuoi();
        void AddDonHang(DonHang donHang);
        void UpdateDonHang(DonHang donHang);
        void DeleteDonHang(DonHang donHang);
    }
}
