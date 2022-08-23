using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Claims;

namespace ToDoClient.Solution.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string ToDos { get; set; }
  }
}