using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RecipeService
    {
        public List<RecipeDto> GetRecipes()
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.RecipeConvertion.Convert(db.Recipe.ToList());
            }

        }
        //אין צורך בתמונה בביט
        //public bool GetRecipes(int Id, byte[] vs)
        //{
        //    using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
        //    {
        //        Recipe p = db.Recipe.FirstOrDefault(x => x.Id == Id);
        //        p.Image = vs;
        //        db.SaveChanges();
        //        return true;
        //    }
        //}
        public List<RecipeDto> GetRecipe(int recipeType)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.RecipeConvertion.Convert(db.Recipe.Where(x => x.RecipeTypeId == recipeType).ToList());
            }

        }
        
    }
}
