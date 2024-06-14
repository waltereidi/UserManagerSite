using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UserManagerSite.MVC.Data;
using UserManagerSite.MVC.Models;

namespace UserManagerSite.MVC.Controllers;

public class UsersController : Controller
{
    private readonly ILogger<UsersController> _logger;
    private readonly ApplicationDbContext _context; 

    public UsersController(ILogger<UsersController> logger , ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Add()
    {
        return View();
    }
}