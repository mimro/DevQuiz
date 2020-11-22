using DevQuiz.Api.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Entities
{
    public class Quiz
    {
        public Guid Id { get; set; }

        public ICollection<Question> Questions { get; set; }

        public string Name { get; set; }

        public QuizTopic QuizTopic { get; set; }

        public QuizLevel QuizLevel { get; set; }
    }
}
