using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
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
      ViewBag.failedLogin = "Login Failed";
      { return View(); }
    }

    [HttpPost]
    public async Task<IActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public async Task<ActionResult> AddToDo(int id)
    {
      string [] result = {};
      ApplicationUser user = await _userManager.GetUserAsync(@User);
      if (user.ToDos != ""){
        result = user.ToDos.Split(":");
      }
      if (Array.Exists(result, e => e == id.ToString()))
      {
        TempData["ErrorMessage"] = "You've already added this To-Do to your list";
        return RedirectToAction("Add", "ToDos"); 
      }
      else if (result.Length >= 6)
      {
        TempData["ErrorMessage"] = "You have too much to do";
        return RedirectToAction("Index", "ToDos");
      }
      else
      {
        user.ToDos += (":" + id);
        _context.Entry(user).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return RedirectToAction("Index", "ToDos");
      }
    }

    [HttpPost]
    public async Task<ActionResult> DeleteAll()
    {
      ApplicationUser user = await _userManager.GetUserAsync(@User);
      user.ToDos="";
      _context.Entry(user).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return RedirectToAction("Index", "ToDos");
    }

    [HttpPost]
    public async Task<ActionResult> Delete(int id)
    {
      string ToDoId = id.ToString();
      ApplicationUser user = await _userManager.GetUserAsync(@User);
      var todos = new List<string>(user.ToDos.Split(":"));
      todos.Remove(ToDoId);
      user.ToDos = String.Join(":", todos.ToArray());
      _context.Entry(user).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return RedirectToAction("Index", "ToDos");
    }
  }
}