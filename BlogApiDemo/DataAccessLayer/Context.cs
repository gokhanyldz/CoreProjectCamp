using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-S3SOUTF\\SQLEXPRESS01;database=CoreProjectBlogApi; integrated security=true;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
