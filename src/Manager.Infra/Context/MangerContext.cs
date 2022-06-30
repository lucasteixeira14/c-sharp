using Manager.Domain.Entities;
using Manager.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Manager.Infra.Context
{
 public class ManagerContext : DbContext
 {
  public ManagerContext()
  { }

  public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
  { }

  public virtual DbSet<User> Users { get; set; }

  protected override void OnModelCreating(ModelBuilder builder)
  {
   builder.ApplyConfiguration(new UserMap());
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlServer(@"Data Source=LUCAS-PC;Database=manager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
 }
}