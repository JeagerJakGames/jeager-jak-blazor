using jeager_jak_blazor.Shared.Enum;
using jeager_jak_blazor.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jeager_jak_blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        // GET: api/<ToDoController>
        [HttpGet]
        public async Task<string> Get()
        {
            var todo = new ToDo();
            var list = new List<ToDo>()
            {
                new ToDo
                {
                    Id = 1,
                    Title = "Test-Title",
                    Type = (int)ToDoType.Normal,
                    Description= "Test-Description",
                    EnteredDate = DateTime.Now,
                    DueByDate = DateTime.Now.AddDays(5),
                },
                 new ToDo
                {
                    Id = 2,
                    Title = "Test-Title",
                    Type = (int)ToDoType.Normal,
                    Description= "Test-Description",
                    EnteredDate = DateTime.Now,
                    DueByDate = DateTime.Now.AddDays(5),
                },
                  new ToDo
                {
                    Id = 3,
                    Title = "Test-Title",
                    Type = (int)ToDoType.Normal,
                    Description= "Test-Description",
                    EnteredDate = DateTime.Now,
                    DueByDate = DateTime.Now.AddDays(5),
                },
            };

            return JsonSerializer.Serialize(list);
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ToDoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
