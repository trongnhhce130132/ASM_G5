using ASMLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.DAO
{
    public class MonAnDAO
    {
   
        public  MonAnDAO() { 
        }

       
        public IEnumerable<MonAn> GetMonAnList()
        {
            List<MonAn> monAns;
            try
            {
               
                var ASMFDB = new ASMFContext();
                var temp = from i in ASMFDB.MonAns where i.Tt == 1 select i;
                monAns = temp.ToList();

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return monAns;
        }
        public String GetIDCuoi()
        {
            List<MonAn> monAns;
           
            try
            {
                var ASMFDB = new ASMFContext();
                monAns = ASMFDB.MonAns.Select((MonAn i) => i).ToList();
                if (monAns.Count <= 0)
                {
                    return "M0001";
                }
                string iDCuoi = monAns.Last().Idmon;
                

                return $"M{int.Parse(iDCuoi.Substring(1)) + 1:000#}";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
        }
        public IEnumerable<MonAn> SearchMonAnByName(String name)
        {
            List<MonAn> monAns;
            try
            {
                var ASMFDB = new ASMFContext();
                var temp = from i in ASMFDB.MonAns where i.Tt == 1 select i;
                monAns = temp.Where(m => m.TenMon.Contains(name)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return monAns;
        }
        public IEnumerable<MonAn> GetMonAnByloai(String loai)
        {
            List<MonAn> monAns;
            try
            {
                var ASMFDB = new ASMFContext();
                monAns = ASMFDB.MonAns.Where(m => m.Idloai.Equals(loai)).Select((MonAn i) => i).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return monAns;
        }
        public MonAn GetMonAnByID(String id)
        { 
            MonAn monAn = null;
            try
            {
                var ASMFDB = new ASMFContext();
                monAn = ASMFDB.MonAns.SingleOrDefault(m => m.Idmon.Equals(id));
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return monAn;
        }
       

        public void AddMonAn(MonAn monAn)
        {
            try
            {
                MonAn _monAn = GetMonAnByID(monAn.Idmon);
                if (_monAn == null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.MonAns.Add(monAn);
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Food is already exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateMonAn(MonAn monAn)
        {
            try
            {
                MonAn _monAn = GetMonAnByID(monAn.Idmon);
                if (_monAn != null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Entry<MonAn>(monAn).State = EntityState.Modified;
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Food does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteMonAn(MonAn monAn)
        {
            try
            {
                MonAn _monAn = GetMonAnByID(monAn.Idmon);
                if (_monAn != null)
                {
                    monAn.Tt = 0;
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Entry<MonAn>(monAn).State = EntityState.Modified;
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Food does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
