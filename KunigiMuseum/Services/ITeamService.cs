using KunigiMuseum.Common;
using KunigiMuseum.Entities;
using KunigiMuseum.ViewModels.Team;

namespace KunigiMuseum.Services;

public interface ITeamService
{
    Task<ServiceResult<Team>> CreateTeamAsync(CreateTeamViewModel viewModel);
    Task<PaginatedResult<Team>> GetPaginatedTeamsAsync(int page, int pageSize);
}