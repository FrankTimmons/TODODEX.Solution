using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ToDoClient.Solution.Models;
using Microsoft.AspNetCore.Identity;

namespace ToDoClient.Solution.Controllers
{
  [Authorize]
  public class ToDosController : Controller
  {
    public IActionResult Index()
    {
      // var allToDos = ToDo.GetToDos();
      // return View(allToDos);
      return View();
    }

    [HttpPost]
    public IActionResult Index(ToDo todo)
    {
      ToDo.Post(todo);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var todo = ToDo.GetDetails(id);
      return View(todo);
    }

    public IActionResult Edit(int id)
    {
      var todo = ToDo.GetDetails(id);
      return View(todo);
    }

    [HttpPost]
    public IActionResult Details(int id, ToDo todo)
    {
      todo.ToDoId = id;
      ToDo.Put(todo);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      ToDo.Delete(id);
      return RedirectToAction("Index");
    }

    public ActionResult Add()
    {
      return View();
    }

  }
}