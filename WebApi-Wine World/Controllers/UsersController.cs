using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using System.Web.Http.Cors;

namespace WebApi_Wine_World.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    public class UsersController : ApiController
    {
        UserService UserService = new UserService();

        // GET: api/Users
        public List<UsersDto> Get()
        {
            return UserService.GetUsers();
        }

        
        public UsersDto Get(int id)
        {
            return UserService.GetUsers(id);///status code 200;
        }
        public IHttpActionResult Get(int id,int points)
        {
             UserService.SetPoints(id,points);
            return Ok();
        }

        // POST: api/Users
        public IHttpActionResult Post(UsersDto user)
        {
            return Ok(UserService.Post(user));
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
