using KunigiMuseum.Mappings;
using KunigiMuseum.Services;
using KunigiMuseum.ViewModels.Team;
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
    
    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost("create")]
    public async Task<IActionResult> Create(CreateTeamViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }
        
        var result = await _teamService.CreateTeamAsync(viewModel);
        
        if (!result.IsSuccess)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.IsNullOrEmpty(error.FieldName) 
                        ? string.Empty : error.FieldName, error.Message);
            }
            
            return View(viewModel);
        }
        
        return RedirectToAction(nameof(Index));
    }
    
    [HttpGet]
    public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 8)
    {
        var result = await _teamService.GetPaginatedTeamsAsync(pageNumber, pageSize);
        var viewModel = result.MapToDetailsViewModel();
        
        return View(viewModel);
    }
}