using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebApi_Wine_World.Controllers
{
    public class ProductsController : ApiController
    {
        //Wine_WorldEntities db = new Wine_WorldEntities();
        // GET: api/Products
        //public List<ProductsDto> Get()
        //{
        //   BLL.UserService
        //}

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
