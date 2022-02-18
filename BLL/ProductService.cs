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
        public bool GetProducts(int Id,byte[] vs)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {

                Product p = db.Product.FirstOrDefault(x => x.Id == Id);
                p.img = vs;
                db.SaveChanges();
                return true;
               
            }

        }
        public List<ProductDto> GetProduct(int ProductTypeId,int tasteId)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.ProductsConvertion.Convert(db.Product.Where(x => x.ProductTypeId == ProductTypeId &&x.TasteId==tasteId).ToList());
            }

        }
        public List<ProductDto> GetProduct(int productType)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.ProductsConvertion.Convert(db.Product.Where(x=>x.ProductTypeId==productType||(productType == -1&&x.ProductType.IsWine.Value)|| (productType == -2 && x.ProductType.IsAccessory.Value)).ToList());
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

