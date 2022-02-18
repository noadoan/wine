using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL.Convertion
{
    class CitiesConvertion
    {
        public static CitiesDto Convert(Cities obj)
        {
            if (obj == null)
                return null;
            return new CitiesDto()
            {
                Id = obj.Id,
                Name = obj.Name,
               
            };
        }
        public static Cities Convert(CitiesDto obj)
        {
            if (obj == null)
                return null;
            return new Cities()
            {
                Id = obj.Id,
                Name = obj.Name,
               
            };
        }
        public static List<Cities> Convert(List<CitiesDto> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<CitiesDto> Convert(List<Cities> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
