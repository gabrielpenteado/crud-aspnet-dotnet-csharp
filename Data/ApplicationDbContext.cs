using api_aspnet_dotnet_csharp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api_aspnet_dotnet_csharp.Data;

public class ApplicationDbContext : IdentityDbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
  {
  }

  public DbSet<Student> Students { get; set; } = default!;
  public DbSet<Subscription> Subscriptions { get; set; } = default!;
}
