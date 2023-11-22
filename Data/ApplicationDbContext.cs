using Microsoft.EntityFrameworkCore;

namespace Aktobe.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<EmployeeInfo> Employees { get; set; }
    }
}
