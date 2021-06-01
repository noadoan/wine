using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DTO
{
    public class UsersDto
    {
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public System.DateTime BornDate { get; set; }
        public Nullable<int> Points { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int HouseNumber { get; set; }
    }
}