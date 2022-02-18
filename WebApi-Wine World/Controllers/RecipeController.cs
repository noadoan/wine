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

    public class RecipeController : ApiController
    {

        RecipeService recipeService = new RecipeService();

        // GET: api/Recipe
        public List<RecipeDto> Get()
        {
            return recipeService.GetRecipes();
        }
        public List<RecipeDto> GetRecipe(int number)
        {
            return recipeService.GetRecipe(number);
        }

        // GET: api/Recipe/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Recipe
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Recipe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Recipe/5
        public void Delete(int id)
        {
        }
    }
}
