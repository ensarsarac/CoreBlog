using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> BlogIncludeWithCategory();

        List<Blog> GetBlogListByWriter(int id);

        List<Blog> WriterBlogWithCategory(int id);

        Blog AdminBlogDetails(int id);


    }
}
