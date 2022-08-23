using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ToDoClient.Solution.Models
{
  public class ToDo
  {
    
    public int ToDoId { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public int PP { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }

    public static List<ToDo> GetToDos()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<ToDo> toDoList = JsonConvert.DeserializeObject<List<ToDo>>(jsonResponse.ToString());

      return toDoList;
    }

    public static ToDo GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      ToDo toDo = JsonConvert.DeserializeObject<ToDo>(jsonResponse.ToString());

      return toDo;
    }

    public static void Post(ToDo toDo)
    {
      string jsonToDo = JsonConvert.SerializeObject(toDo);
      var apiCallTask = ApiHelper.Post(jsonToDo);
    }

    public static void Put(ToDo toDo)
    {
      string jsonToDo = JsonConvert.SerializeObject(toDo);
      var apiCallTask = ApiHelper.Put(toDo.ToDoId, jsonToDo);
    }

     public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}