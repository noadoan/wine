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
        public int QuestioId { get; set; }
        public byte[] Img { get; set; }
        public Nullable<int> IdTypeWine { get; set; }
        public Nullable<int> Points { get; set; }
    }
}
