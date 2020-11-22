using DevQuiz.Api.Enums;
using System.Collections;
using System.Collections.Generic;

namespace DevQuiz.Api.Models
{
    public class QuizDto
    {
        public IEnumerable<QuestionDto> Questions { get;set; }

        public string QuizId { get; set; }

        public string Name { get; set; }

        public QuizTopic QuizTopic { get; set; }

        public QuizLevel QuizLevel { get; set; }
    }
}
