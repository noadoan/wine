using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Convertion
{
    class TasteConvertion
    {
        public static TasteDto Convert(Taste obj)
        {
            if (obj == null)
                return null;
            return new TasteDto()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }
        public static Taste Convert(TasteDto obj)
        {
            if (obj == null)
                return null;
            return new Taste()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }
        public static List<Taste> Convert(List<TasteDto> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<TasteDto> Convert(List<Taste> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
