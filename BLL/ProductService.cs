using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductService
    {

        public List<ProductDto> GetProducts()
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.ProductsConvertion.Convert(db.Product.ToList());
            }

        }
        public ProductDto GetProducts(int id)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.ProductsConvertion.Convert(db.Product.FirstOrDefault(x => x.Id == id));
            }
        }
       
      
    }
}

