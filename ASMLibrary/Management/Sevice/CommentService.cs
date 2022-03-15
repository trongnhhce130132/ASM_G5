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
    public class CommentService : ICommentService
    {
        CommentDAO Comment = new CommentDAO();

        public IEnumerable<Comment> GetCommentList() => Comment.GetCommentList();
        public String GetIDCuoi() => Comment.GetIDCuoi();
        public IEnumerable<Comment> GetCommentByIDKhachHang(String id) => Comment.GetCommentByIDKhachHang(id);
        public IEnumerable<Comment> GetCommentByIDMon(String id) => Comment.GetCommentByIDMon(id);
        public Comment GetCommentByID(String id) => Comment.GetCommentByID(id);
        public void AddComment(Comment comment) => Comment.AddComment(comment);
        public void DeleteComment(Comment comment) => Comment.DeleteComment(comment);
        public void UpdateComment(Comment comment) => Comment.UpdateComment(comment);
    }
}
