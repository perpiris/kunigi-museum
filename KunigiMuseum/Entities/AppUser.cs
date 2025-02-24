using Microsoft.AspNetCore.Identity;

namespace KunigiMuseum.Entities;

public class AppUser : IdentityUser
{
    public virtual ICollection<TeamManager> ManagedTeams { get; set; }
}