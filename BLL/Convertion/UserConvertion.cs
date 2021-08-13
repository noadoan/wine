using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Convertion
{
  public  class UserConvertion
    {
        public static UsersDto Convert(User user)
        {
            if (user == null)
                return null;
             return  new UsersDto()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                BornDate = user.BornDate,
                Points = user.Points,
                Mail = user.Mail,
                Password = user.Password,
                Address = user.Address,
                City = user.City,
                HouseNumber = user.HouseNumber,
            };
        }
        public static User Convert(UsersDto user)
        {
            if (user == null)
                return null;
            return new User()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                BornDate = user.BornDate,
                Points = user.Points,
                Mail = user.Mail,
                Password = user.Password,
                Address = user.Address,
                City = user.City,
                HouseNumber = user.HouseNumber,
            };
        }
        public static List<User> Convert(List<UsersDto> users)
        {
            return users.Select(x => Convert(x)).ToList();
        }
        public static List<UsersDto> Convert(List<User> users)
        {
            return users.Select(x => Convert(x)).ToList();
        }
    }
}
