using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Entities
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string QuestionText { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public Guid? QuizId { get; set; }

        public Quiz Quiz { get; set; }
    }
}
