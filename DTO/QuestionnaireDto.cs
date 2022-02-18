using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuestionnaireDto
    {
        public int Id { get; set; }
        public string QuestionContent { get; set; }
        public List<AnswerDto> Answers { get; set; }

    }
}
