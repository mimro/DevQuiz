using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Entities
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        public string AnswerText { get; set; }

        public int? QuestionId { get; set; }

        public Question Question { get; set; }

        public bool IsCorrectAnswer { get; set; }
    }
}
