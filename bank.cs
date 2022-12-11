using Microsoft.EntityFrameworkCore;

namespace Packt.Shared
{
  // this manages the connection to the database
  public class bank : DbContext
  {
    // these properties map to tables in the database 
    public DbSet<Account> Accounts { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(
      ModelBuilder modelBuilder)
    {
      // global filter to remove discontinued products
      modelBuilder.Entity<Account>()
        .HasQueryFilter(p => !p.Discontinued);
    }
    
  }
}