using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Claims;

namespace ToDoClient.Solution.Models
{
  public class ApplicationUser : IdentityUser
  {
    public ApplicationUser()
    {
      this.ToDos = new HashSet<ToDo>();
    }
    public virtual ICollection<ToDo> ToDos { get; set; }
  }
  
}