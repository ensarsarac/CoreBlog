using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void AddComment(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public List<Comment> AdminCommentWithUser()
        {
            return _commentDal.CommentListWithUser();
        }

        public List<Comment> CommentWithUser(int id)
        {
            return _commentDal.CommentWithUser(id);
        }

        public List<Comment> getList()
        {
            return _commentDal.GetListAll();
        }

        public List<Comment> getList(int id)
        {
            return _commentDal.GetListAll(x=>x. BlogId == id);
        }
        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public void TAdd(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
