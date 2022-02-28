using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Convertion
{
    class ProductsConvertion
    {
        public static ProductDto Convert(Product obj)
        {
            if (obj == null)
                return null;
            return new ProductDto()
            {
                Id = obj.Id,
                Name = obj.Name,
                Price = obj.Price,
                YearProduction = obj.YearProduction,
                Description = obj.Description,
                WineId = obj.WineId,
                ProductTypeId = obj.ProductTypeId,
                TasteId = obj.TasteId,
                PercentageAlcohol = obj.PercentageAlcohol,
                img=obj.img,
                kosher=obj.Category?.Name,
                kosherId=obj.kosherId,
                SalePrice=obj.SalePrice
            };
        }
        public static Product Convert(ProductDto obj)
        {
            if (obj == null)
                return null;
            return new Product()
            {
                Id = obj.Id,
                img=obj.img,
                Name = obj.Name,
                Price = obj.Price,
                YearProduction = obj.YearProduction,
                Description = obj.Description,
                WineId = obj.WineId,
                ProductTypeId = obj.ProductTypeId,
                TasteId = obj.TasteId,
                PercentageAlcohol = obj.PercentageAlcohol,
                SalePrice=obj.SalePrice,
                kosherId=obj.kosherId
            };
        }
        public static List<Product> Convert(List<ProductDto> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<ProductDto> Convert(List<Product> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
