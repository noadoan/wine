using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Convertion
{
    class QuestionnaireConvertion
    {
        public static QuestionnaireDto Convert(Questionnaire obj)
        {
            if (obj == null)
                return null;
            return new QuestionnaireDto()
            {
                Id = obj.Id,
                QuestionContent = obj.QuestionContent,
                Answers=AnswerConvertion.Convert(obj.Answer.ToList()),


            };
        }
        public static Questionnaire Convert(QuestionnaireDto obj)
        {
            if (obj == null)
                return null;
            return new Questionnaire()
            {
                Id = obj.Id,
                QuestionContent = obj.QuestionContent,
            };
        }
        public static List<Questionnaire> Convert(List<QuestionnaireDto> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<QuestionnaireDto> Convert(List<Questionnaire> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
