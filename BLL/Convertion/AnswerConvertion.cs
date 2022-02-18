using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Convertion
{
   public class AnswerConvertion
    {
        public static AnswerDto Convert(Answer obj)
        {
            if (obj == null)
                return null;
            return new AnswerDto()
            {
                Id = obj.Id,
                AnswerContent=obj.AnswerContent,
                Img=obj.Img,
                QuestioId=obj.QuestioId,
                Points=obj.Points==null?0:(int)obj.Points,
                IdTypeWine=obj.IdTypeWine
                
            };
        }
        public static Answer Convert(AnswerDto obj)
        {
            if (obj == null)
                return null;
            return new Answer()
            {
                Id = obj.Id,
                AnswerContent = obj.AnswerContent,
                Img = obj.Img,
                Points = obj.Points,
                QuestioId = obj.QuestioId,
                IdTypeWine=obj.IdTypeWine
                
            };
        }
        public static List<Answer> Convert(List<AnswerDto> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<AnswerDto> Convert(List<Answer> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
