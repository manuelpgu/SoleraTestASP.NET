using ASPPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPPrueba.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
     
        public DbSet<Owners> owners { get; set; }

        public DbSet<Vehicles> vehicules { get; set; }

        public DbSet<Claims> claims { get; set; }
    }
}
