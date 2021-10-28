using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using simple_api.Models;

namespace simple_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private SimpleApiDbContext dbContext;

        public DataController(SimpleApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<SimpleData> Get()
        {
            return dbContext.SimpleDatas.AsEnumerable().Take(10);
        }

        [HttpPost]
        public IActionResult Create([FromBody] SimpleData data)
        {
            dbContext.SimpleDatas.Add(data);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}