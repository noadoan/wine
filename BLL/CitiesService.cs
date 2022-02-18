using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class CitiesService
    {
        public List<CitiesDto> GetCities()
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.CitiesConvertion.Convert(db.Cities.ToList());
            }

        }
    }
}
