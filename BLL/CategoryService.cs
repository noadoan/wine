using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class CategoryService
    {
        public List<CategoryDto> Get()
        {
            //ביחד עם שרה
            using (Wine_WorldEntities db = new Wine_WorldEntities())
            {
                return Convertion.CategoryConvertion.Convert(db.Category.ToList());
            }

        }
        public CategoryDto Get(int id)
        {
            using (Wine_WorldEntities db = new Wine_WorldEntities())
            {
                return Convertion.CategoryConvertion.Convert(db.Category.FirstOrDefault(x => x.Id == id));
            }
        }

        public CategoryDto Post(CategoryDto CategoryDto)
        {
            using (Wine_WorldEntities db = new Wine_WorldEntities())
            {
                Category Category = db.Category.Add(Convertion.CategoryConvertion.Convert(CategoryDto));
                db.SaveChanges();
                return Convertion.CategoryConvertion.Convert(Category);
            }
        }
        public CategoryDto Put(CategoryDto CategoryDto, int id)
        {
            using (Wine_WorldEntities db = new Wine_WorldEntities())
            {
                Category Category = db.Category.FirstOrDefault(x => x.Id == id);
                if (Category == null)
                    return null;

                Category.Name = CategoryDto.Name;
                db.SaveChanges();
                return Convertion.CategoryConvertion.Convert(Category);
            }
        }
    }
}
