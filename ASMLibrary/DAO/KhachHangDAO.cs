using ASMLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.DAO
{
    public class KhachHangDAO
    {
        public KhachHangDAO() { }
        public IEnumerable<KhachHang> GetKhachHangList()
        {
            List<KhachHang> khachHangs;
            try
            {
                var ASMFDB = new ASMFContext();
                var temp = from i in ASMFDB.KhachHangs where i.Tt == 1 select i;
                khachHangs = temp.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return khachHangs;
        }

        public String GetIDCuoi()
        {
            List<KhachHang> khachHangs;

            try
            {
                var ASMFDB = new ASMFContext();
                khachHangs = ASMFDB.KhachHangs.Select((KhachHang i) => i).ToList();
                if (khachHangs.Count <= 0)
                {
                    return "KH001";
                }
                string iDCuoi = khachHangs.Last().Idkh;

                return $"KH{int.Parse(iDCuoi.Substring(2)) + 1:00#}";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public IEnumerable<KhachHang> SearchKhachHangByName(string Name)
        {
            List<KhachHang> khachHangs;
            try
            {
                var ASMFDB = new ASMFContext();
                var temp = from i in ASMFDB.KhachHangs where i.Tt == 1 select i;
                khachHangs = temp.Where(k => k.HotenKh.Contains(Name)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return khachHangs;
        }
        public KhachHang GetKhachHangByID(string id)
        {
            KhachHang khachHang = null;
            try
            {
                var ASMFDB = new ASMFContext();
                khachHang = ASMFDB.KhachHangs.SingleOrDefault(m => m.Idkh.Equals(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return khachHang;
        }
        public KhachHang CheckUserName(string username)
        {
            KhachHang khachHang = null;
            try
            {
                var ASMFDB = new ASMFContext();
                khachHang = ASMFDB.KhachHangs.SingleOrDefault(m => m.Username.Equals(username));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return khachHang;
        }
        public KhachHang CheckLogin(string username, string password)
        {
            KhachHang khachHang = null;
            try
            {
                var ASMFDB = new ASMFContext();
                khachHang = ASMFDB.KhachHangs.SingleOrDefault(m => m.Username.Equals(username) && m.Password.Equals(password));
            }
            catch (Exception ex)
            {
                return null;
            }
            return khachHang;
        }

        public void AddKhachHang(KhachHang khachHang)
        {
            try
            {
                KhachHang _khachHang = GetKhachHangByID(khachHang.Idkh);
                if (_khachHang == null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.KhachHangs.Add(khachHang);
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("KhachHang is already exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateKhachHang(KhachHang khachHang)
        {
            try
            {
                KhachHang _khachHang = GetKhachHangByID(khachHang.Idkh);
                if (_khachHang != null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Entry<KhachHang>(khachHang).State = EntityState.Modified;
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("KhachHang does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteKhachHang(KhachHang khachHang)
        {
            try
            {
                KhachHang _khachHang = GetKhachHangByID(khachHang.Idkh);

                if (_khachHang != null)
                {
                    khachHang.Tt = 0;
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Entry<KhachHang>(khachHang).State = EntityState.Modified;
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("KhachHang does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
