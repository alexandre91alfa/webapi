using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("site/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Event>> Get()
        {
            return new Event[] {
                new Event{EventoId = 1,
                    Tema = "Angular e dotnetCore",
                    Local = "São Paulo",
                    Lote = "1° lote",
                    QtPessoas = 200,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")},
                new Event{EventoId = 2,
                    Tema = "web dotnetCore",
                    Local = "São Paulo",
                    Lote = "1° lote",
                    QtPessoas = 2000,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")}
            
        };

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
