using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ToDoAPI.Models;

namespace ToDoAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ToDosController : ControllerBase
  {
    private readonly ToDoAPIContext _db;

    public ToDosController(ToDoAPIContext db)
    {
      _db = db;
    }

    /// <summary>
    /// Grabs a list of ToDos.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ToDo>>> Get()
    {
      return await _db.ToDos.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<ToDo>> Post(ToDo toDo)
    {
      _db.ToDos.Add(toDo);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetToDo), new { id = toDo.ToDoId }, toDo);
    }

    /// <summary>
    /// Grabs a specific ToDo by id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns>A specific ToDo</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<ToDo>> GetToDo(int id)
    {
      var toDo = await _db.ToDos.FindAsync(id);

      if (toDo == null)
      {
        return NotFound();
      }

      return toDo;
    }

    /// <summary>
    /// modifies a specific ToDO.
    /// </summary>
    /// <param name="toDo"></param>
    /// <param name="id"></param>
    /// <returns>A newly updated Todo</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     PUT api/ToDo/1
    ///     {
    ///        "ToDoId": 1,
    ///        "Name": "Washoo",
    ///        "Category": "Time",
    ///        "PP": 7,
    ///        "Health": 25
    ///     }
    ///
    /// </remarks>
    /// <response code="201">Returns the newly updated toDo</response>
    /// <response code="400">If the ToDo is null</response>
    // PUT: api/todo/1
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, ToDo toDo)
    {
      if (id != toDo.ToDoId)
      {
        return BadRequest();
      }

      _db.Entry(toDo).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ToDoExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    /// <summary>
    /// Deletes a specific ToDo.
    /// </summary>
    /// <param name ="id"></param>
    // DELETE: api/toDo/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteToDo(int id)
    {
      var toDo = await _db.ToDos.FindAsync(id);
      if (toDo == null)
      {
        return NotFound();
      }

      _db.ToDos.Remove(toDo);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool ToDoExists(int id)
    {
      return _db.ToDos.Any(e => e.ToDoId == id);
    }
  }
}