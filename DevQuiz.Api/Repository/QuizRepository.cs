using DevQuiz.Api.Context;
using DevQuiz.Api.Entities;
using DevQuiz.Api.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Repository
{
    public class QuizRepository : IQuizRepository
    {
        public readonly QuizContext quizContext;
        public QuizRepository(QuizContext quizContext)
        {
            this.quizContext = quizContext;
        }

        public void Add<T>(T entity) where T : class
        {
            this.quizContext.Add(entity);
        }

        public void Delete(Guid Id)
        {
            var quiz = this.quizContext.Quizzes.Where(q => q.Id == Id).Include(q => q.Questions).ThenInclude(a => a.Answers); 
            this.quizContext.Remove(quiz);
        }

        public async Task<IEnumerable<Quiz>> GetAllQuizesAsync()
        {
            IEnumerable<Quiz> quizzes = this.quizContext.Quizzes
                .Include(q => q.Questions)
                .ThenInclude(a => a.Answers);

            return quizzes;
        }

        public async Task<Quiz> GetQuizById(Guid Id)
        {
            Quiz quiz = this.quizContext.Quizzes
                .Include(q => q.Questions)
               .ThenInclude(a => a.Answers)
                .FirstOrDefault(q => q.Id == Id);

            return quiz;
        }

        public async Task<IEnumerable<Quiz>> GetQuizesByTopicAsync(QuizTopic quizTopic)
        {
            IEnumerable<Quiz> quizzes = this.quizContext.Quizzes;

            quizzes = quizzes.Where(t => t.QuizTopic == quizTopic);
            return quizzes;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await this.quizContext.SaveChangesAsync()) > 0;
        }
    }
}
