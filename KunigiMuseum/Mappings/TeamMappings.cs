using KunigiMuseum.Common;
using KunigiMuseum.Entities;
using KunigiMuseum.ViewModels.Common;
using KunigiMuseum.ViewModels.Team;

namespace KunigiMuseum.Mappings;

public static class TeamMappings
{
    public static TeamDetailsViewModel MapToDetailsViewModel(this Team team)
    {
        return new TeamDetailsViewModel
        {
            TeamId = team.TeamId,
            Name = team.Name,
            Slug = team.Slug,
            IsActive = team.IsActive,
            FoundedYear = team.FoundedYear,
            Description = team.Description,
            FacebookUrl = team.FacebookUrl,
            InstagramUrl = team.InstagramUrl,
            YoutubeUrl = team.YoutubeUrl,
            WebsiteUrl = team.WebsiteUrl
        };
    }

    public static PaginatedViewModel<TeamDetailsViewModel> MapToDetailsViewModel(this PaginatedResult<Team> result)
    {
        return new PaginatedViewModel<TeamDetailsViewModel>
        {
            Items = result.Items.Select(x => x.MapToDetailsViewModel()).ToList(),
            CurrentPage = result.Page,
            TotalPages = result.TotalPages,
            PageSize = result.PageSize,
            TotalItems = result.TotalItems
        };
    }
}