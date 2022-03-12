using ASMLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.DAO
{
    public class ChiTietDonHangDAO
    {
        public ChiTietDonHangDAO() { 
        }
        public IEnumerable<ChiTietDonHang> GetChiTietDonHangList()
        {
            List<ChiTietDonHang> chiTietDonHangs;
            try
            {
                var ASMFDB = new ASMFContext();
                chiTietDonHangs = ASMFDB.ChiTietDonHangs.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return chiTietDonHangs;
        }
        public String GetIDCuoi()
        {
            List<ChiTietDonHang> chiTietDonHangs;

            try
            {
                var ASMFDB = new ASMFContext();
                chiTietDonHangs = ASMFDB.ChiTietDonHangs.Select((ChiTietDonHang i) => i).ToList();
                if (chiTietDonHangs.Count <= 0)
                {
                    return "C0001";
                }
                string iDCuoi = chiTietDonHangs.Last().Idctdh;

                return $"C{int.Parse(iDCuoi.Substring(1)) + 1:000#}";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public IEnumerable<ChiTietDonHang> GetChiTietDonHangByIDDonHang(String id)
        {
            List<ChiTietDonHang> chiTietDonHangs;
            try
            {
                var ASMFDB = new ASMFContext();
                chiTietDonHangs = ASMFDB.ChiTietDonHangs.Where(g => g.IddonHang.Equals(id)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return chiTietDonHangs;
        }
      
        public ChiTietDonHang GetChiTietDonHangByID(String id)
        {
            ChiTietDonHang chiTietDonHang = null;
            try
            {
                var ASMFDB = new ASMFContext();
                chiTietDonHang = ASMFDB.ChiTietDonHangs.SingleOrDefault(m => m.Idctdh.Equals(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return chiTietDonHang;
        }

        public void AddChiTietDonHang(ChiTietDonHang chiTietDonHang)
        {
            try
            {
                ChiTietDonHang _chiTietDonHang = GetChiTietDonHangByID(chiTietDonHang.Idctdh);
                if (_chiTietDonHang == null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.ChiTietDonHangs.Add(chiTietDonHang);
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("ChiTietDonHang is already exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateChiTietDonHang(ChiTietDonHang chiTietDonHang)
        {
            try
            {
                ChiTietDonHang _chiTietDonHang = GetChiTietDonHangByID(chiTietDonHang.Idctdh);
                if (_chiTietDonHang != null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Entry<ChiTietDonHang>(chiTietDonHang).State = EntityState.Modified;
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("ChiTietDonHang does not already exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteChiTietDonHang(ChiTietDonHang chiTietDonHang)
        {
            try
            {
                ChiTietDonHang _chiTietDonHang = GetChiTietDonHangByID(chiTietDonHang.Idctdh);
                if (_chiTietDonHang != null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.ChiTietDonHangs.Remove(chiTietDonHang);
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("ChiTietDonHang does not already exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
