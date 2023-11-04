using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using SweetOrSavory.Models;

namespace SweetOrSavory.Controllers;

public class HomeController : Controller
{
    private readonly SweetOrSavoryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser> userManager, SweetOrSavoryContext db)
    {
        _userManager = userManager;
        _db = db;
    }

    [HttpGet("/")]
    public async Task<ActionResult> Index()
    {
        string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
