using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDoAPI.Models
{
  public class ToDo
  {
    public int ToDoId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [Range(0, 100, ErrorMessage = "Age must be between 0 and 200.")]
    public int PP { get; set; }

    [Required]
    public string Category { get; set; }

    [Required]
    public string Description { get; set; }

    public string Image { get; set; }
  }
}