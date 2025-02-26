using KunigiMuseum.Common;
using KunigiMuseum.Data;
using KunigiMuseum.Entities;
using KunigiMuseum.ViewModels.Team;
using Microsoft.EntityFrameworkCore;

namespace KunigiMuseum.Services.Implementation;

public class TeamService : ITeamService
{
    private readonly DataContext _context;

    public TeamService(DataContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        
        _context = context;
    }
    
    public async Task<ServiceResult<Team>> CreateTeamAsync(CreateTeamViewModel createModel)
    {
        if (await _context.Teams.AnyAsync(t => t.Name == createModel.Name))
        {
            return ServiceResult<Team>.Failure("Name", "A team with this name already exists.");
        }
        
        var team = new Team
        {
            Name = createModel.Name,
        };
        
        _context.Teams.Add(team);
        await _context.SaveChangesAsync();
        
        return ServiceResult<Team>.Success(team);
    }

    public async Task<PaginatedResult<Team>> GetPaginatedTeamsAsync(int page, int pageSize)
    {
        var query = _context.Teams.AsNoTracking();

        var totalItems = await query.CountAsync();
        var items = await query
            .OrderBy(x => x.Name)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PaginatedResult<Team>
        {
            Items = items,
            TotalItems = totalItems,
            Page = page,
            PageSize = pageSize,
            TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize)
        };
    }
}