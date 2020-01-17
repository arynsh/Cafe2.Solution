using Microsoft.EntityFrameworkCore;

namespace Cafe.Models
{
  public class CafeContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public CafeContext(DbContextOptions options) : base(options) { }
  }
}