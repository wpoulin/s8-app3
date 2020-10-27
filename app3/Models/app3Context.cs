using Microsoft.EntityFrameworkCore;

namespace app3.Models
{
    public class app3Context : DbContext
    {
        public app3Context(DbContextOptions<app3Context> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<NuclearCode> Nuclear_codes { get; set; }
    }
}
