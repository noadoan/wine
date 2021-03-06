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
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.AnswerConvertion.Convert(db.Answer.ToList());
            }

        }
        public AnswerDto Get(int id)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                return Convertion.AnswerConvertion.Convert(db.Answer.FirstOrDefault(x => x.Id == id));
            }
        }

        public AnswerDto Post(AnswerDto AnswerDto)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                Answer Answer = db.Answer.Add(Convertion.AnswerConvertion.Convert(AnswerDto));
                db.SaveChanges();
                return Convertion.AnswerConvertion.Convert(Answer);
            }
        }
        public AnswerDto Put(AnswerDto AnswerDto, int id)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                Answer Answer = db.Answer.FirstOrDefault(x => x.Id == id);
                if (Answer == null)
                    return null;

                Answer.AnswerContent = AnswerDto.AnswerContent;
                Answer.Img = AnswerDto.Img;
                Answer.QuestioId = AnswerDto.QuestioId;
                Answer.IdTypeWine = AnswerDto.IdTypeWine;
                db.SaveChanges();
                return Convertion.AnswerConvertion.Convert(Answer);
            }

        }
        public bool GetAnswers(int Id, byte[] vs)
        {
            using (Wine_WorldEntities1 db = new Wine_WorldEntities1())
            {
                Answer a = db.Answer.FirstOrDefault(x => x.Id == Id);
                a.Img = vs;
                db.SaveChanges();
                return true;
            }

        }



    }
}
