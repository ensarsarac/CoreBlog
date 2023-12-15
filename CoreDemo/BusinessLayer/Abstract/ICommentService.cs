using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        void AddComment(Comment comment);
        List<Comment> getList(int id);

        List<Comment> CommentWithUser(int id);

        List<Comment> AdminCommentWithUser();

    }
}
