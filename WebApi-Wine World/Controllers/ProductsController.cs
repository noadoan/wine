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
    [EnableCors(origins:"*",methods:"*",headers:"*")]
    public class ProductsController : ApiController
    {
        //Wine_WorldEntities db = new Wine_WorldEntities();
        //GET: api/Products
        //public List<ProductsDto> Get()
        //{
        //    BLL.UserService
        //}

        UserService UserService = new UserService();

        // GET: api/Users
        public List<UsersDto> Get()
        {
            return UserService.GetUsers();
        }

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
