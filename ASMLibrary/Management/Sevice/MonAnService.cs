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
        MonAnDAO monAnDAO = new MonAnDAO();
        public void AddMonAn(MonAn monAn) => monAnDAO.AddMonAn(monAn);

        public void DeleteMonAn(MonAn monAn) => monAnDAO.DeleteMonAn(monAn);

        public MonAn GetMonAnByID(string ID) => monAnDAO.GetMonAnByID(ID);

        public IEnumerable<MonAn> GetMonAns() => monAnDAO.GetMonAnList();

        public IEnumerable<MonAn> SearchMonAnByName(String name) => monAnDAO.SearchMonAnByName(name);

        public void UpdateMonAn(MonAn monAn) => monAnDAO.UpdateMonAn(monAn);

        public String GetIDCuoi() => monAnDAO.GetIDCuoi();
    }
}
