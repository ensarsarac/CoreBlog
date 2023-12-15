using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class DashboardList
    {
        public IEnumerable<Blog> blogList;
        public Writer writer;
        public IEnumerable<Comment> commentList;
    }
}
