using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevQuiz.Api.Repository
{
    public interface IRepository<T>
    {
        Task Add(T entity);

        Task<T> GetAll();

    }
}
