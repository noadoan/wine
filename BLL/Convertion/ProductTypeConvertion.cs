using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Convertion
{
    class ProductTypeConvertion
    {
        public static ProductTypeDto Convert(ProductType obj)
        {
            if (obj == null)
                return null;
            return new ProductTypeDto()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }
        public static ProductType Convert(ProductTypeDto obj)
        {
            if (obj == null)
                return null;
            return new ProductType()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }
        public static List<ProductType> Convert(List<ProductTypeDto> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<ProductTypeDto> Convert(List<ProductType> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
