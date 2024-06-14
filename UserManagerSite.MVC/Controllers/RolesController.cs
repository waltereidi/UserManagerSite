using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManagerSite.Domain.Models;
using UserManagerSite.MVC.Data;
using UserManagerSite.MVC.Models;

namespace UserManagerSite.MVC.Controllers;

public class RolesController : Controller
{
    private readonly ILogger<RolesController> _logger;

    private readonly ApplicationDbContext _context; 
    public RolesController(ILogger<RolesController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        IEnumerable<Role> roles = await _context.Role.ToListAsync();
        return View(roles);
    }

    public IActionResult Add()
    {
        return View();
    }
    
}