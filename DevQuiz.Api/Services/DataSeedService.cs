using AutoMapper.Internal;
using DevQuiz.Api.Entities;
using DevQuiz.Api.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Services
{
    public class DataSeedService : IDataSeedService
    {
        private readonly IQuizRepository quizRepository;
        public DataSeedService(IQuizRepository quizRepository)
        {
            this.quizRepository = quizRepository;
        }

        public IEnumerable<Quiz> Quizzes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task Seed(string jsonPath)
        {
                var jsonData = await System.IO.File.ReadAllTextAsync(jsonPath);

                var quizzes = JsonConvert.DeserializeObject<IEnumerable<Quiz>>(jsonData);

               // Action a =>  this.quizRepository.Add(q);

        }
    }
}
