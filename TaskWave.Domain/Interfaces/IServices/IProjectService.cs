using TaskWave.Domain.Entities;

namespace TaskWave.Domain.Interfaces.IServices
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAllProjectsAsync();
        Task<Project> GetProjectByIdAsync(int id);
        Task<Project> CreateProjectAsync(Project proj);
        Task UpdateProjectAsync(Project proj);
        Task DeleteProjectAsync(int id);
    }
}
