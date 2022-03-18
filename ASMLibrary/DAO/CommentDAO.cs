using ASMLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.DAO
{
    public class CommentDAO
    {
        public CommentDAO() { }
        public IEnumerable<Comment> GetCommentList()
        {
            List<Comment> Comments;
            try
            {
                var ASMFDB = new ASMFContext();
                Comments = ASMFDB.Comments.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Comments;
        }

        public String GetIDCuoi()
        {
            List<Comment> Comments;

            try
            {
                var ASMFDB = new ASMFContext();
                Comments = ASMFDB.Comments.Select((Comment i) => i).ToList();
                if (Comments.Count <= 0)
                {
                    return "CM001";
                }
                string iDCuoi = Comments.Last().Idcomment;

                return $"CM{int.Parse(iDCuoi.Substring(1)) + 1:00#}";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public IEnumerable<Comment> GetCommentByIDKhachHang(String id)
        {
            List<Comment> Comments;
            try
            {
                var ASMFDB = new ASMFContext();
                Comments = ASMFDB.Comments.Where(g => g.Idkh.Equals(id)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Comments;
        }
        public IEnumerable<Comment> GetCommentByIDMon(String id)
        {
            List<Comment> Comments;
            try
            {
                var ASMFDB = new ASMFContext();
                Comments = ASMFDB.Comments.Where(g => g.Idmon.Equals(id)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Comments;
        }
        public Comment GetCommentByID(String id)
        {
            Comment comment = null;
            try
            {
                var ASMFDB = new ASMFContext();
                comment = ASMFDB.Comments.SingleOrDefault(m => m.Idcomment.Equals(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return comment;
        }

        public void AddComment(Comment comment)
        {
            try
            {
                Comment _comment = GetCommentByID(comment.Idcomment);
                if (_comment == null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Comments.Add(comment);
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Comment is exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateComment(Comment comment)
        {
            try
            {
                Comment _comment = GetCommentByID(comment.Idcomment);
                if (_comment != null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Entry<Comment>(comment).State = EntityState.Modified;
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Comment does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteComment(Comment comment)
        {
            try
            {
                Comment _comment = GetCommentByID(comment.Idcomment);
                if (_comment != null)
                {
                    var ASMFDB = new ASMFContext();
                    ASMFDB.Comments.Remove(comment);
                    ASMFDB.SaveChanges();
                }
                else
                {
                    throw new Exception("Comment does not exist.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
