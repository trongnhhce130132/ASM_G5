using ASMLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.DAO
{
    public class GioHangDAO
    {
        public GioHangDAO() { }
        public IEnumerable<GioHang> GetGioHangList()
        {
            List<GioHang> gioHangs;
            try
            {
                var ASMFDB = new ASMFContext();
                gioHangs = ASMFDB.GioHangs.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return gioHangs;
        }
        public String GetIDCuoi()
        {
            List<GioHang> gioHangs;

            try
            {
                var ASMFDB = new ASMFContext();
                gioHangs = ASMFDB.GioHangs.Select((GioHang i) => i).ToList();
                if (gioHangs.Count <= 0)
                {
                    return "G0001";
                }
                string iDCuoi = gioHangs.Last().IdgioHang;

                return $"G{int.Parse(iDCuoi.Substring(1)) + 1:000#}";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public IEnumerable<GioHang> GetGioHangByIDKhachHang(String id)
        {
            List<GioHang> gioHangs;
            try
            {
                var ASMFDB = new ASMFContext();
                gioHangs = ASMFDB.GioHangs.Where(g => g.Idkh.Equals(id)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return gioHangs;
        }
        public GioHang GetGioHangByID(String id)
        {
            GioHang gioHang = null;
            try
            {
                var ASMFDB = new ASMFContext();
                gioHang = ASMFDB.GioHangs.SingleOrDefault(m => m.IdgioHang.Equals(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return gioHang;
        }

        public void AddGioHang(GioHang gioHang)
        {
            try
            {
                GioHang _gioHang = GetGioHangByID(gioHang.IdgioHang);
                if (_gioHang == null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.GioHangs.Add(gioHang);
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("GioHang is already exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateGioHang(GioHang gioHang)
        {
            try
            {
                GioHang _gioHang = GetGioHangByID(gioHang.IdgioHang);
                if (_gioHang != null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Entry<GioHang>(gioHang).State = EntityState.Modified;
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("GioHang does not already exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteGioHang(GioHang gioHang)
        {
            try
            {
                GioHang _gioHang = GetGioHangByID(gioHang.IdgioHang);
                if (_gioHang != null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.GioHangs.Remove(gioHang);
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("GioHang does not already exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
