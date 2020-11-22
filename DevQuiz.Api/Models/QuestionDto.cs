using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Models
{
    public class QuestionDto
    {
        public string QuestionText { get; set; }

        public IEnumerable<AnswerDto> Answers { get; set; }
    }
}
