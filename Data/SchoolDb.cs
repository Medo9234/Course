using Demo1.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Data
{
    public class SchoolDb : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\sqlExpress;database=Database1;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
