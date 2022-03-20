using ASMLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.Management.IService
{
    public interface IMonAnService
    {
        IEnumerable<MonAn> GetMonAnByloai(String loai);
        IEnumerable<MonAn> GetMonAns();
        IEnumerable<MonAn> SearchMonAnByName(String name);
        String GetIDCuoi();
        MonAn GetMonAnByID(String ID);
        void AddMonAn(MonAn monAn);
        void DeleteMonAn(MonAn monAn);
        void UpdateMonAn(MonAn monAn);
    }
}
