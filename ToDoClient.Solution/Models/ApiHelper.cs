using System.Threading.Tasks;
using RestSharp;

namespace ToDoClient.Solution.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"todos", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"todos/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newToDo)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"todos", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newToDo);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newToDo)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"todos/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newToDo);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5002/api");
      RestRequest request = new RestRequest($"todos/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
    
  }
}