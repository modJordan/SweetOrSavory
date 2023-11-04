using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SweetOrSavory.Models
{
  public class SweetOrSavoryContext: IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<TreatFlavor> FlavorTreat { get; set; }
    public SweetOrSavoryContext(DbContextOptions options) : base(options) { }
  }
}