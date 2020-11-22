using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Entities
{
    public class Answer
    {
        public Guid Id { get; set; }

        public string AnswerText { get; set; }

        public Guid? QuestionId { get; set; }

        public Question Question { get; set; }

        public bool IsCorrectAnswer { get; set; }
    }
}
