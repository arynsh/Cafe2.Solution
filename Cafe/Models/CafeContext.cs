using Microsoft.EntityFrameworkCore;

namespace Cafe.Models
{
  public class CafeContext : DbContext
  {
   //DBSet Cuisine refers to the cuisine table in database and Cuisines is a variable that the table is set to
    public virtual DbSet<Cuisine> Cuisines { get; set; }
   // /DBSet Restaurant refers to the restaurant table in database and and Restaurants is a variable that the table is set to

    public DbSet<Restaurant> Restaurants { get; set; }
    public CafeContext(DbContextOptions options) : base(options) { }
  }
}