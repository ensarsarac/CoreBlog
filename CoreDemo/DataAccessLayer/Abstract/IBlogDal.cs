using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> BlogIncludeWithCategory();
        List<Blog> WriterBlogWithCategory(int id);
        List<Blog> GetListAll();

        Blog GetByIdWithCategory(int id);

    }
}
