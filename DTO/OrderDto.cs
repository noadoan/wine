using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDto
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> UserId { get; set; }

        
    }
}
