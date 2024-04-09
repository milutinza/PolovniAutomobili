using Microsoft.EntityFrameworkCore;
using PolovniAutomobili.Models;

namespace PolovniAutomobili.Contexts
{
    public class AutomobiliDbContext : DbContext
    {
        public AutomobiliDbContext(DbContextOptions<AutomobiliDbContext> options) : base(options)

        {

        }
        public DbSet<Automobil> Automobil { get; set; }
    }
}
