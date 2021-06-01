using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Convertion
{
    class SysdiagramsConvertion
    {
        public static SysdiagramsDto Convert(sysdiagrams obj)
        {
            if (obj == null)
                return null;
            return new SysdiagramsDto()
            {
                name = obj.name,
                principal_id = obj.principal_id,
                diagram_id = obj.diagram_id,
                version = obj.version,
                definition = obj.definition,
            };


        }
        public static sysdiagrams Convert(SysdiagramsDto obj)
        {
            if (obj == null)
                return null;
            return new sysdiagrams()
            {
                name = obj.name,
                principal_id = obj.principal_id,
                diagram_id = obj.diagram_id,
                version = obj.version,
            };
        }
        public static List<sysdiagrams> Convert(List<SysdiagramsDto> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<SysdiagramsDto> Convert(List<sysdiagrams> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
