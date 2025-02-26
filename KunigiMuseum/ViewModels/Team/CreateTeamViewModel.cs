using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KunigiMuseum.ViewModels.Team;

public class CreateTeamViewModel
{
    [DisplayName("Όνομα Ομάδας")]
    [Required(ErrorMessage = "Το πεδίο απαιτείται.")]
    [StringLength(150)]
    public required string Name { get; set; }

    [DisplayName("Ενεργή")] public bool IsActive { get; set; } = true;
}