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
    public class LoaiService : ILoaiService
    {
        LoaiDAO loaiDAO = new LoaiDAO();
        public IEnumerable<Loai> GetLoais() => loaiDAO.GetloaiList();
        public string GetIDCuoi() => loaiDAO.GetIDCuoi();
        public Loai GetLoaiByID(string id) => loaiDAO.GetLoaiByID(id);
        public void AddLoai(Loai loai) => loaiDAO.AddLoai(loai);
        public void DeleteLoai(Loai loai) => loaiDAO.DeleteLoai(loai);
        public void UpdateLoai(Loai loai) => loaiDAO.UpdateLoai(loai);
    }
}
