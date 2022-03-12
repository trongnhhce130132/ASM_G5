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
    public class MonAnService : IMonAnService
    {
        public void AddMonAn(MonAn monAn) => MonAnDAO.Instance.AddMonAn(monAn);

        public void DeleteMonAn(MonAn monAn) => MonAnDAO.Instance.DeleteMonAn(monAn);

        public MonAn GetMonAnByID(string ID) => MonAnDAO.Instance.GetMonAnByID(ID);

        public IEnumerable<MonAn> GetMonAns() => MonAnDAO.Instance.GetMonAnList();

        public IEnumerable<MonAn> SearchMonAnByName(String name) => MonAnDAO.Instance.SearchMonAnByName(name);

        public void UpdateMonAn(MonAn monAn) => MonAnDAO.Instance.UpdateMonAn(monAn);

        public String GetIDCuoi() => MonAnDAO.Instance.GetIDCuoi();
    }
}
