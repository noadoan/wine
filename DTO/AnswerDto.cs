using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class AnswerDto
    {
        public int Id { get; set; }
        public string AnswerContent { get; set; }
        public byte[] Image { get; set; }
        public int QuestioId { get; set; }

       
    }
}
