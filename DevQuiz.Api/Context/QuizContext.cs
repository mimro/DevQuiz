using DevQuiz.Api.Entities;
using DevQuiz.Api.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Context
{
    public class QuizContext : DbContext
    {

        public QuizContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Quiz> Quizzes { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer(this.config.GetConnectionString("Quiz"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var quizId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA314}");
            var questionId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA315}");
            var Quiz1 = new Quiz
            {
                Id = quizId,
                Name = "Test 1",
                QuizLevel = QuizLevel.Easy,
                QuizTopic = QuizTopic.CSharp,

            };
            var Question1 = new Question
            {
                Id = questionId,
                QuestionText = "TestQuestion",
                QuizId = quizId
            };

            var Answer1 = new Answer { 
            AnswerText= "TestAnswer",
            Id = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA123}"),
            IsCorrectAnswer = true,
            QuestionId = questionId
            };

            modelBuilder.Entity<Quiz>().HasData(Quiz1);

            modelBuilder.Entity<Question>().HasData(Question1);

            modelBuilder.Entity<Answer>().HasData(Answer1);
        }
    }
}
