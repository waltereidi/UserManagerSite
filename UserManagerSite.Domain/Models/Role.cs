using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace UserManagerSite.Domain.Models;

public class Role
{
    public int? id {get; set;}
    [StringLength(100, MinimumLength=3)]
    [Required]
    public string? role {get; set;}
    public virtual ICollection<User>? Users { get; set; }
}