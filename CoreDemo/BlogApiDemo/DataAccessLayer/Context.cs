using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JI387RJ\\SQLEXPRESS; database=CoreBlogDbApi; integrated security=true;");
        }

        public DbSet<Employee> Employes{ get; set; }
    }
}
