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
    public class DonHangService : IDonHangService
    {
        DonHangDAO DonHang = new DonHangDAO();


        public IEnumerable<DonHang> GetDonHangList() => DonHang.GetDonHangList();
        public IEnumerable<DonHang> GetDonHangByIDKhachHang(String id) => DonHang.GetDonHangByIDKhachHang(id);
        public DonHang GetDonHangByID(String id) => DonHang.GetDonHangByID(id);
        public String GetIDCuoi() => DonHang.GetIDCuoi();
        public void AddDonHang(DonHang donHang) => DonHang.AddDonHang(donHang);
        public void UpdateDonHang(DonHang donHang) => DonHang.UpdateDonHang(donHang);
        public void DeleteDonHang(DonHang donHang) => DonHang.DeleteDonHang(donHang);
    }
}
