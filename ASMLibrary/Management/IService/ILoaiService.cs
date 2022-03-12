using ASMLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.Management.IService
{
    public interface ILoaiService
    {
        IEnumerable<Loai> GetLoais();
        String GetIDCuoi();
        Loai GetLoaiByID(string id);
        void AddLoai(Loai loai);
        void DeleteLoai(Loai loai);
        void UpdateLoai(Loai loai);



    }
}
