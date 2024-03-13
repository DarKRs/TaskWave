using TaskWave.Domain.Entities;
using TaskWave.Domain.Interfaces.IRepositories;
using TaskWave.Domain.Interfaces.IServices;

namespace TaskWave.Infrastructure.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IBaseRepository<Project> _projectRepository;

        public ProjectService(IBaseRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            return await _projectRepository.GetAllAsync();
        }

        public async Task<Project> GetProjectByIdAsync(int id)
        {
            return await _projectRepository.GetByIdAsync(id);
        }

        public async Task<Project> CreateProjectAsync(Project proj)
        {
            await _projectRepository.AddAsync(proj);
            return proj;
        }

        public async Task UpdateProjectAsync(Project task)
        {
            await _projectRepository.UpdateAsync(task);
        }

        public async Task DeleteProjectAsync(int id)
        {
            await _projectRepository.DeleteAsync(id);
        }


    }
}
