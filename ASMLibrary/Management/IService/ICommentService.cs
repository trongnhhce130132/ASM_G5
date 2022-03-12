using ASMLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMLibrary.Management.IService
{
    public interface ICommentService
    {
        IEnumerable<Comment> GetCommentList();
        String GetIDCuoi();
        IEnumerable<Comment> GetCommentByIDKhachHang(String id);
        IEnumerable<Comment> GetCommentByIDMon(String id);
        Comment GetCommentByID(String id);
        void AddComment(Comment comment);
        void DeleteComment(Comment comment);
        void UpdateComment(Comment comment);
    }
}
