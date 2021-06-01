using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Convertion
{
    class RecipeTypeConvertion
    {
        public static RecipeTypeDto Convert(RecipeType obj)
        {
            if (obj == null)
                return null;
            return new RecipeTypeDto()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }
        public static RecipeType Convert(RecipeTypeDto obj)
        {
            if (obj == null)
                return null;
            return new RecipeType()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }
        public static List<RecipeType> Convert(List<RecipeTypeDto> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<RecipeTypeDto> Convert(List<RecipeType> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
