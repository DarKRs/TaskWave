using TaskWave.Domain.Entities;
using TaskWave.Domain.Interfaces.IRepositories;
using TaskWave.Domain.Interfaces.IServices;

namespace TaskWave.Infrastructure.Services
{
    public class TaskService : ITaskService
    {
        private readonly IBaseRepository<ProjectTask> _taskRepository;

        public TaskService(IBaseRepository<ProjectTask> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<ProjectTask>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllAsync();
        }

        public async Task<ProjectTask> GetTaskByIdAsync(int id)
        {
            return await _taskRepository.GetByIdAsync(id);
        }

        public async Task<ProjectTask> CreateTaskAsync(ProjectTask task)
        {
            await _taskRepository.AddAsync(task);
            return task;
        }

        public async Task UpdateTaskAsync(ProjectTask task)
        {
            await _taskRepository.UpdateAsync(task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            await _taskRepository.DeleteAsync(id);
        }
    }
}
