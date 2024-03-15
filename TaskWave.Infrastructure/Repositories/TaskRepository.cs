using Microsoft.EntityFrameworkCore;
using TaskWave.Domain.Entities;
using TaskWave.Domain.Interfaces.IRepositories;
using TaskWave.Infrastructure.Data;

namespace TaskWave.Infrastructure.Repositories
{
    public class TaskRepository : BaseRepository<ProjectTask>, ITaskRepository
    {
        public TaskRepository(TaskManagementContext context) : base(context)
        {
        }

        public async Task<ProjectTask> GetTaskByIdWithProjectAsync(int id)
        {
            return await _context.Tasks.Include(t => t.Project).FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}
