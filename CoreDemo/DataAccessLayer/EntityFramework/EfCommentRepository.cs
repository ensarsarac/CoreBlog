using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
        Context c = new Context();

        public List<Comment> CommentListWithUser()
        {
            return c.Comments.Include(x => x.AppUser).Include(y=>y.Blog).ToList();
        }

        public List<Comment> CommentWithUser(int id)
        {
            return c.Comments.Include(x => x.AppUser).Where(y=>y.BlogId==id).ToList();
        }

    }
}
