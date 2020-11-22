using AutoMapper;
using DevQuiz.Api.Entities;
using DevQuiz.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Profiles
{
    public class QuizProfile : Profile
    {
        public QuizProfile()
        {
            CreateMap<Quiz, QuizDto>().ForMember(q => q.QuizId, p => p.MapFrom(t => Convert.ToBase64String(t.Id.ToByteArray()))); 
            CreateMap<Question, QuestionDto>();
            CreateMap<Answer, AnswerDto>();
        }
    }
}
