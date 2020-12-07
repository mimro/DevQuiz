using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DevQuiz.Api.Entities;
using DevQuiz.Api.Enums;
using DevQuiz.Api.Extensions;
using DevQuiz.Api.Models;
using DevQuiz.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DevQuiz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizzesController : ControllerBase
    {
        private readonly IQuizRepository quizRepository;
        private readonly IMapper mapper;

        public QuizzesController(IQuizRepository quizRepository, IMapper mapper)
        {
            this.quizRepository = quizRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuizDto>>> Get(int? topicId)
        {
            IEnumerable < Quiz > result;
            try
            {
                if (topicId == null)
                {
                    result = await this.quizRepository.GetAllQuizesAsync();
                }
                else
                {
                    result = await this.quizRepository.GetQuizesByTopicAsync((QuizTopic)topicId);
                }
                if (result != null)
                {
                    var dto = mapper.Map<List<QuizDto>>(result);
                    return Ok(dto);
                }
                else return StatusCode(404);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{quizId}")]
        public async Task<ActionResult<QuizDto>> Get(string quizId)
        {
            Quiz quiz = await this.quizRepository.GetQuizById(quizId.DecodetFromBase64String());
            var dto = mapper.Map<QuizDto>(quiz);

            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<QuizDto>> Post(Quiz quiz)
        {
            this.quizRepository.Add<Quiz>(quiz);
            await this.quizRepository.SaveChangesAsync();
          //  var dto = mapper.Map<List<QuizDto>>(quiz);
            return Ok(quiz);
        }

        [HttpDelete("{quizId}")]
        public async Task<ActionResult<QuizDto>> Delete(string quizId)
        {

            this.quizRepository.Delete(Guid.Parse(quizId));
            await this.quizRepository.SaveChangesAsync();
            //  var dto = mapper.Map<List<QuizDto>>(quiz);
            return Ok(quizId);
        }
    }
}