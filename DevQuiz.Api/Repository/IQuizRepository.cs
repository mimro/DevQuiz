using DevQuiz.Api.Entities;
using DevQuiz.Api.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Repository
{
    public interface IQuizRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete(Guid Id);

        Task<bool> SaveChangesAsync();

        Task<IEnumerable<Quiz>> GetAllQuizesAsync();

        Task<IEnumerable<Quiz>> GetQuizesByTopicAsync(QuizTopic quizTopicId);

        Task<Quiz> GetQuizById(Guid Id);

    }
}
