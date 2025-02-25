using KunigiMuseum.Data;

namespace KunigiMuseum.Services.Implementation;

public class GameService : IGameService
{
    private readonly DataContext _context;

    public GameService(DataContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        
        _context = context;
    }
}