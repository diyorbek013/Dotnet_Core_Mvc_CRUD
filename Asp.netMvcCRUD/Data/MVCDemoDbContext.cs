using Asp.netMvcCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Asp.netMvcCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
