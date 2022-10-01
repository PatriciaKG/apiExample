using System;
using System.Collections.Generic;
using Desafio.Model;

namespace Desafio.Data.Repository
{

    public interface ITaskRepository
    {
        void Add(Task aTask);

        void Update(string id, Task UpdatedTask);

        IEnumerable<Task> Get();
        
        Task Get(string id);

        void Delete(string id);
    }
}