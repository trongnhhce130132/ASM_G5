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
    public class KhachHangSevice : IKhachHangService
    {
        KhachHangDAO KhachHang = new KhachHangDAO();
        public IEnumerable<KhachHang> GetKhachHangs() => KhachHang.GetKhachHangList();
        public String GetIDCuoi() => KhachHang.GetIDCuoi();
        public KhachHang CheckLogin(string username, string password) => KhachHang.CheckLogin(username, password);  
        public IEnumerable<KhachHang> SearchKhachHangByName(String Name) => KhachHang.SearchKhachHangByName(Name);
        public KhachHang GetKhachHangByID(String id) => KhachHang.GetKhachHangByID(id);
        public void AddKhachHang(KhachHang khachHang) => KhachHang.AddKhachHang(khachHang);
        public void UpdateKhachHang(KhachHang khachHang) => KhachHang.UpdateKhachHang(khachHang);
        public void DeleteKhachHang(KhachHang khachHang) => KhachHang.DeleteKhachHang(khachHang);

    }
}
