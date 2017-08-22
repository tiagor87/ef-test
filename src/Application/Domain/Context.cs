using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Application.Domain
{
  public class Context : DbContext
  {
    public Context(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Pessoa> Pessoas { get; set; }
  }
}