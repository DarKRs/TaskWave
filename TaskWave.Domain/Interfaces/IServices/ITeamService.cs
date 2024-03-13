using TaskWave.Domain.Entities;

namespace TaskWave.Domain.Interfaces.IServices
{
    public interface ITeamService
    {
        Task<IEnumerable<Team>> GetAllTeamssAsync();
        Task<Team> GetTeamByIdAsync(int id);
        Task<Team> CreateTeamAsync(Team team);
        Task UpdateTeamAsync(Team team);
        Task DeleteTeamAsync(int id);
    }
}
