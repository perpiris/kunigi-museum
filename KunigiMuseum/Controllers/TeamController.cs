using KunigiMuseum.Services;
using Microsoft.AspNetCore.Mvc;

namespace KunigiMuseum.Controllers;

[Route("teams")]
public class TeamController : Controller
{
    private readonly ITeamService _teamService;

    public TeamController(ITeamService teamService)
    {
        ArgumentNullException.ThrowIfNull(teamService);
        
        _teamService = teamService;
    }
}