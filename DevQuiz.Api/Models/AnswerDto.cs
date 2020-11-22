using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Models
{
    public class AnswerDto
    {
        public string AnswerText { get; set; }

        public bool IsCorrectAnswer { get; set; }
    }
}
