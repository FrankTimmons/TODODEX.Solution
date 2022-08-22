using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ToDoClient.Solution.Models
{
  public class ToDoClientContext : IdentityDbContext<ApplicationUser>
  {
    public ToDoClientContext(DbContextOptions<ToDoClientContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

  }
}