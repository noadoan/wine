using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class TasteService
    {
        public List<TasteDto> GetTaste(int typeId)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.TasteConvertion.Convert(db.Taste.Where(x=>x.IdTypeWine==typeId).ToList());
            }

        }
    }
}
