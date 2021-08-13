using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class UserService
    {
        public List<UsersDto> GetUsers()
        {
          using(Wine_WorldEntities1 db =new Wine_WorldEntities1())
            {
               return  Convertion.UserConvertion.Convert(db.User.ToList());
            }
          
        }
        public UsersDto GetUsers(int id)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.UserConvertion.Convert(db.User.FirstOrDefault(x=>x.Id==id));
            }
        }
        public UsersDto GetUsers(string mail,string Password)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.UserConvertion.Convert(db.User.FirstOrDefault(x => x.Mail == mail&&x.Password==Password));
            }
        }
        public UsersDto Post(UsersDto usersDto)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                User user = db.User.Add(Convertion.UserConvertion.Convert(usersDto));
                db.SaveChanges();
                return Convertion.UserConvertion.Convert(user);
            }
        }
        public UsersDto Put(UsersDto usersDto,int id)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                User user = db.User.FirstOrDefault(x => x.Id == id);
                if (user == null)
                    return null;
                user.LastName = usersDto.LastName;
                user.FirstName = usersDto.FirstName;
                user.HouseNumber = usersDto.HouseNumber;
                db.SaveChanges();
                return Convertion.UserConvertion.Convert(user);
            }
        }
    }
}
