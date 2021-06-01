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
                Image=obj.Image,
                QuestioId=obj.QuestioId,
              
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
                Image = obj.Image,
                QuestioId = obj.QuestioId
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
