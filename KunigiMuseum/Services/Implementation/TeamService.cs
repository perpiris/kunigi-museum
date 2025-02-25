using KunigiMuseum.Data;

namespace KunigiMuseum.Services.Implementation;

public class TeamService : ITeamService
{
    private readonly DataContext _context;

    public TeamService(DataContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        
        _context = context;
    }
}