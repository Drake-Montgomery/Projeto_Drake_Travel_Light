using Microsoft.EntityFrameworkCore;

namespace Drake_Travel_Light.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Voo> Voo { get; set; }
    }
}
