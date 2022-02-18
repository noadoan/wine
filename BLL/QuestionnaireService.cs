using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuestionnaireService
    {
        public List<QuestionnaireDto> GetQuestionnire()
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.QuestionnaireConvertion.Convert(db.Questionnaire.ToList());
            }

        }
    }
}
