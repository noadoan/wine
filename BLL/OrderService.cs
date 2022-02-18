using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class OrderService
    {
      
            public OrderDto AddOrder(OrderDto orderDto)
            {
                using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
                {
                    Order order= db.Order.Add( Convertion.OrderConvertion.Convert(orderDto));
                    db.SaveChanges();
                    return Convertion.OrderConvertion.Convert(order);
                }

            }
       
    }
}
