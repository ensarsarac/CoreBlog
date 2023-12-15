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
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        Context c = new Context();  
        public List<Blog> BlogIncludeWithCategory()
        {
            
            return c.Blogs.Include(m => m.Category).OrderByDescending(i => i.BlogCreateDate).ToList();
        }

        public Blog GetByIdWithCategory(int id)
        {
            return c.Blogs.Include(x => x.Category).Include(z=>z.Writer).Where(y => y.BlogId == id).FirstOrDefault();
        }

        public List<Blog> WriterBlogWithCategory(int id)
        {
            return c.Blogs.Include(c => c.Category).Where(x => x.WriterId == id).ToList();
        }
    }
}
