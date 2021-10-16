using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotesController : Controller
    {
       static List<Quotes> _quotes = new List<Quotes>()
        {
            new Quotes(){id = 1, Author = "Vishal", Description = "New Quote written by Vishal", Title = "Overcome" }
        };

        [HttpGet] 
        public IEnumerable<Quotes> Get()
        {
            return _quotes;
        }
        [HttpPost]
        public void Post([FromBody]Quotes quote)
        {
            //add record
            _quotes.Add(quote);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Quotes quotes)
        {
            _quotes[id] = quotes;
        }
        [HttpDelete("{id}")]
        public void Delte(int id)
        {
            _quotes.RemoveAt(id);
        }
    }
}
