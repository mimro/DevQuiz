using AutoMapper;
using DevQuiz.Api.Entities;
using DevQuiz.Api.Extensions;
using DevQuiz.Api.Models;
using Microsoft.IdentityModel.Tokens;
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
            CreateMap<Quiz, QuizDto>().ForMember(q => q.QuizId, p => p.MapFrom(t => t.Id.EncodetToBase64String())); 
            CreateMap<Question, QuestionDto>();
            CreateMap<Answer, AnswerDto>();
        }
    }
}
