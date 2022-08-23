using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using ToDoClient.Solution.ViewModels;
using ToDoClient.Solution.Models;

namespace ToDoClient.Solution.Controllers
{
  public class AccountsController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly ToDoClientContext _context;

    public AccountsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ToDoClientContext context)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _context = context;
    }

    public ActionResult Index()
    { return View(); }

    public IActionResult Register()
    { return View(); }

    [HttpPost]
    public async Task<ActionResult> Register (RegisterViewModel model)
    {
      var user = new ApplicationUser { UserName = model.Username };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded) 
      { return RedirectToAction("Index"); }
      else
      { return View(); }
    }

    public ActionResult Login()
    { return View(); }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      { return RedirectToAction("Index"); }
      else
      { return View(); }
    }

    [HttpPost]
    public async Task<IActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<ActionResult> AddToDo(int id)
    {
      ApplicationUser user = await _userManager.GetUserAsync(@User);
      user.ToDos += (":" + id);
      _context.Entry(user).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return RedirectToAction("Index", "ToDos");
    }

  }
}