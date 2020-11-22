using DevQuiz.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Services
{
    public class DataSeedService : IDataSeedService
    {
        public IEnumerable<Quiz> Quizzes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
