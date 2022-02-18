using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Convertion
{
    class RecipeConvertion
    {
        public static RecipeDto Convert(Recipe obj)
        {
            if (obj == null)
                return null;
            return new RecipeDto()
            {
                Id = obj.Id,
                RecipeTypeId = obj.RecipeTypeId,
                Name = obj.Name,
                ImageUrl = obj.ImageUrl

            };
        }
        public static Recipe Convert(RecipeDto obj)
        {
            if (obj == null)
                return null;
            return new Recipe()
            {
                Id = obj.Id,
                RecipeTypeId = obj.RecipeTypeId,
                Name = obj.Name,
                ImageUrl=obj.ImageUrl
            };
        }
        public static List<Recipe> Convert(List<RecipeDto> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<RecipeDto> Convert(List<Recipe> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
