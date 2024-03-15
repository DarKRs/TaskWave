using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskWave.Domain.Entities;

namespace TaskWave.Domain.Interfaces.IRepositories
{
    public interface ITaskRepository : IBaseRepository<ProjectTask>
    {
        Task<ProjectTask> GetTaskByIdWithProjectAsync(int id);
    }
}
