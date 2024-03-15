using TaskWave.Domain.Entities;

namespace TaskWave.Domain.Interfaces.IServices
{
    public interface ITaskService
    {
        Task<IEnumerable<ProjectTask>> GetAllTasksAsync();
        Task<ProjectTask> GetTaskByIdAsync(int id);
        Task<ProjectTask> GetTaskByIdWithProjectAsync(int id);
        Task<ProjectTask> CreateTaskAsync(ProjectTask task);
        Task UpdateTaskAsync(ProjectTask task);
        Task DeleteTaskAsync(int id);
    }
}
