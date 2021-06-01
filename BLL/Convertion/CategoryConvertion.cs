using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Convertion
{
    class CategoryConvertion
    {
        public static CategoryDto Convert(Category obj)
        {
            if (obj == null)
                return null;
            return new CategoryDto()
            {
                Id = obj.Id,
               Name=obj.Name,
            };
        }
        public static Category Convert(CategoryDto obj)
        {
            if (obj == null)
                return null;
            return new Category()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }
        public static List<Category> Convert(List<CategoryDto> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<CategoryDto> Convert(List<Category> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
