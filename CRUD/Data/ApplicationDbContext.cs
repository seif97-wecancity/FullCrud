using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Student> Students { set; get; }
        public DbSet<Employee> Employees { set; get; }
        public DbSet<Supplier> Suppliers { set; get; }
    }
}
