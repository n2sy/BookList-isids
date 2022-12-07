using Microsoft.EntityFrameworkCore;
using TP_ISIE_21.Model;

namespace TP_ISIE_21.Model
{
     public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options)
            {
            }

            public DbSet<Book> Livre {get; set; }
        }
}