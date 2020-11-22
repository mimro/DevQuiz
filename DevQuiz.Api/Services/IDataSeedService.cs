using DevQuiz.Api.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Services
{
    interface IDataSeedService
    {
        public IEnumerable<Quiz> Quizzes { get; set; }

        public async Task Seed(string jsonPath)
        {
            var jsonData = await System.IO.File.ReadAllTextAsync(jsonPath);

            var quizzes = JsonConvert.DeserializeObject<IEnumerable<Quiz>>(jsonData);


        }
    }
}
