using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL;
using DTO;

namespace WebApi_Wine_World.Controllers
{

    [EnableCors(origins: "*", methods: "*", headers: "*")]

    public class TasteController : ApiController
    {
        TasteService tasteService = new TasteService();

        // GET: api/Products
        public List<TasteDto> Get(int typeId)
        {
            return tasteService.GetTaste(typeId);
        }

       

        // POST: api/Taste
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Taste/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Taste/5
        public void Delete(int id)
        {
        }
    }
}
