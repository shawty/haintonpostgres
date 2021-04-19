using efpostgres.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace efpostgres.Database
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options)
      : base(options) { }

    public DbSet<StandardData> StandardData { get; set; }
    public DbSet<IdentityData> IdentityData { get; set; }
    public DbSet<AdvancedData> AdvancedData { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<StandardData>().Property(p => p.Pkid).UseSerialColumn();
      modelBuilder.Entity<IdentityData>().Property(p => p.Pkid).UseIdentityAlwaysColumn();
      modelBuilder.Entity<AdvancedData>().Property(p => p.Pkid).UseSerialColumn();
    }

  }
}
