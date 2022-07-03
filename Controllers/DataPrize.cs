using APICore.DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using APICore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataPrize : ControllerBase
    {

        private readonly PrizeDbContext _context;

        public DataPrize(PrizeDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("all")]
        public IActionResult GetAllPrizes()
        {
            var prize1 = _context.Prizes.ToList();

            return Ok(prize1);
        }

        //Add Post Request
        [HttpPost]
        [Route("post1")]
        public string Post(Prize prize1)
        {
            try
            {

                _context.Seed();
                return "Prize Added";
            }
            catch (Exception)
            {
                return "Enter Correct credentials!";
            }
        }


        // GET: api/<DataPrize>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DataPrize>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DataPrize>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DataPrize>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DataPrize>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

     
    }
}
