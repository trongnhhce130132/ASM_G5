using ASMLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.DAO
{
    public class LoaiDAO
    {
        
        public LoaiDAO()
        {
        }
        public IEnumerable<Loai> GetloaiList()
        {
            List<Loai> loais;
            try
            {
                var ASMFDB = new ASMFContext();
                loais = ASMFDB.Loais.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return loais;
        }
        public String GetIDCuoi()
        {
            List<Loai> loais;

            try
            {
                var ASMFDB = new ASMFContext();
                loais = ASMFDB.Loais.Select((Loai i) => i).ToList();
                if (loais.Count <= 0)
                {
                    return "L0001";
                }
                string iDCuoi = loais.Last().Idloai;
     
                return $"L{int.Parse(iDCuoi.Substring(1)) + 1:000#}";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public Loai GetLoaiByID(String id)
        {
            Loai loai = null;
            try
            {
                var ASMFDB = new ASMFContext();
                loai = ASMFDB.Loais.SingleOrDefault(m => m.Idloai.Equals(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return loai;
        }

        public void AddLoai(Loai loai)
        {
            try
            {
                Loai _loai = GetLoaiByID(loai.Idloai);
                if (_loai == null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Loais.Add(loai);
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Category is already exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateLoai(Loai loai)
        {
            try
            {
                Loai _loai = GetLoaiByID(loai.Idloai);
                if (_loai != null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Entry<Loai>(loai).State = EntityState.Modified;
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Category does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteLoai(Loai loai)
        {
            try
            {
                Loai _loai = GetLoaiByID(loai.Idloai);
                if (_loai != null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Loais.Remove(loai);
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Category does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
