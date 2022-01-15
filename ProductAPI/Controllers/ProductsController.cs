using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public int  Get(int id)
        {
            return  852;
        }

        // POST api/<ProductController>
        [HttpPost]
        public string Post()
        {
            return "The product name is Rice";
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public string Put()
        {
            return "We are updating the product with price";
        }

        // DELETE api/<ProductController>/5
        [HttpDelete]
        public string Delete()
        {
            return "The product will be deleted if you want to delete";
        }
    }
}
