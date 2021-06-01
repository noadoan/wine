using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Convertion
{
    class OrderConvertion
    {
        public static OrderDto Convert(Order obj)
        {
            if (obj == null)
                return null;
            return new OrderDto()
            {
                 Id =obj.Id,
                 Date=obj.Date, 
                 UserId=obj.UserId, 
    };
        }
        public static Order Convert(OrderDto obj)
        {
            if (obj == null)
                return null;
            return new Order()
            {
                Id = obj.Id,
                Date = obj.Date,
                UserId = obj.UserId,
            };
        }
        public static List<Order> Convert(List<OrderDto> users)
        {
            return users.Select(x => Convert(x)).ToList();
        }
        public static List<OrderDto> Convert(List<Order> users)
        {
            return users.Select(x => Convert(x)).ToList();
        }
    }
}
