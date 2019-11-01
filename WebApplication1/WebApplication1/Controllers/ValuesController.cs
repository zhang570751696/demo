using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Message;
using WebApplication1.Notifiy;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly INotifierMediatorService _notifierMediatorService;

        private readonly IMessageMediatorService _messageMediatorService;

        public ValuesController(INotifierMediatorService notifierMediatorService, 
            IMessageMediatorService messageMediatorService)
        {
            this._notifierMediatorService = notifierMediatorService;
            this._messageMediatorService = messageMediatorService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(string id)
        {
            var data = await this._messageMediatorService.Request(id);
            return data;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            this._notifierMediatorService.Notify(value);
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
