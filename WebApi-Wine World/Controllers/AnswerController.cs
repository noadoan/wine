using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace WebApi_Wine_World.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]

    public class AnswerController : ApiController
    {
         AnswerService  answerService = new AnswerService();

        // GET: api/Products
        public List<AnswerDto> Get()
        {
            return answerService.Get();
        }

        // GET: api/Answer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Answer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Answer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Answer/5
        public void Delete(int id)
        {
        }
    }
}
