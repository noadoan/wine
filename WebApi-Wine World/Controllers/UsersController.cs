using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
namespace WebApi_Wine_World.Controllers
{
    public class UsersController : ApiController
    {
        UserService UserService = new UserService();

        // GET: api/Users
        public List<UsersDto> Get()
        {
            return UserService.GetUsers();
        }
        //ככככככ
        //IHttpActionResult status הבקשה
        // GET: api/Users/5
    //     if (user.mail =="")
    //            return BadRequest("נשלח מייל לא תקין");//400
    //        if (user.userId==0)
    //            return NotFound();//404
    //        ////
    //        return Ok(user);///status code 200;
    //}
        public UsersDto Get(int id)
        {
            return UserService.GetUsers(id);///status code 200;
        }

        // POST: api/Users
        public IHttpActionResult Post(UsersDto user)
        {
            return Ok( UserService.Post(user));
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
