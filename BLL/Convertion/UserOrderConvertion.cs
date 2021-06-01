using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Convertion
{
    class UserOrderConvertion
    {
        public static UserOrderDto Convert(UserOrder obj)
        {
            if (obj == null)
                return null;
            return new UserOrderDto()
            {
                ProductId = obj.ProductId,
                OrderId = obj.OrderId,
                Price = obj.Price,
            };
        }
        public static UserOrder Convert(UserOrderDto obj)
        {
            if (obj == null)
                return null;
            return new UserOrder()
            {
                ProductId = obj.ProductId,
                OrderId = obj.OrderId,
                Price = obj.Price,
            };
        }
        public static List<UserOrder> Convert(List<UserOrderDto> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<UserOrderDto> Convert(List<UserOrder> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
