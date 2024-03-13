using TaskWave.Domain.Entities;
using TaskWave.Domain.Interfaces.IRepositories;
using TaskWave.Domain.Interfaces.IServices;

namespace TaskWave.Infrastructure.Services
{
    public class TeamService : ITeamService
    {
        private readonly IBaseRepository<Team> _teamRepository;

        public TeamService(IBaseRepository<Team> teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<IEnumerable<Team>> GetAllTeamssAsync()
        {
            return await _teamRepository.GetAllAsync();
        }

        public async Task<Team> GetTeamByIdAsync(int id)
        {
            return await _teamRepository.GetByIdAsync(id);
        }

        public async Task<Team> CreateTeamAsync(Team team)
        {
            await _teamRepository.AddAsync(team);
            return team;
        }

        public async Task UpdateTeamAsync(Team team)
        {
            await _teamRepository.UpdateAsync(team);
        }

        public async Task DeleteTeamAsync(int id)
        {
            await _teamRepository.DeleteAsync(id);
        }


    }
}
