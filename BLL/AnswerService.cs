using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class AnswerService
    {
        public List<AnswerDto> Get()
        {
            using (Wine_WorldEntities db = new Wine_WorldEntities())
            {
                return Convertion.AnswerConvertion.Convert(db.Answer.ToList());
            }

        }
        public AnswerDto Get(int id)
        {
            using (Wine_WorldEntities db = new Wine_WorldEntities())
            {
                return Convertion.AnswerConvertion.Convert(db.Answer.FirstOrDefault(x => x.Id == id));
            }
        }
       
        public AnswerDto Post(AnswerDto AnswerDto)
        {
            using (Wine_WorldEntities db = new Wine_WorldEntities())
            {
                Answer Answer = db.Answer.Add(Convertion.AnswerConvertion.Convert(AnswerDto));
                db.SaveChanges();
                return Convertion.AnswerConvertion.Convert(Answer);
            }
        }
        public AnswerDto Put(AnswerDto AnswerDto, int id)
        {
            using (Wine_WorldEntities db = new Wine_WorldEntities())
            {
                Answer Answer = db.Answer.FirstOrDefault(x => x.Id == id);
                if (Answer == null)
                    return null;

                Answer.AnswerContent = AnswerDto.AnswerContent;
                Answer.Image = AnswerDto.Image;
                Answer.QuestioId = AnswerDto.QuestioId;
                db.SaveChanges();
                return Convertion.AnswerConvertion.Convert(Answer);
            }
        }
    }
}
