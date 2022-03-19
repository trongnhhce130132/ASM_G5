using ASMLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.Management.IService
{
    public interface IKhachHangService
    {
        IEnumerable<KhachHang> GetKhachHangs();
        String GetIDCuoi();
        IEnumerable<KhachHang> SearchKhachHangByName(String Name);
        KhachHang GetKhachHangByID(String id);
        KhachHang CheckLogin(string username, string password);
        void AddKhachHang(KhachHang khachHang);
        void UpdateKhachHang(KhachHang khachHang);
        void DeleteKhachHang(KhachHang khachHang);
        KhachHang CheckUserName(string username);

    }
}
