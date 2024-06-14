using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagerSite.Domain.Models;

namespace UserManagerSite.MVC.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Role> Role { get; set; } = null!;
    public DbSet<User> User { get; set; } = null!;

}
