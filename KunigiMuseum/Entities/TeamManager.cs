namespace KunigiMuseum.Entities;

public class TeamManager
{
    public Guid TeamManagerId { get; set; }

    public Guid TeamId { get; set; }

    public string AppUserId { get; set; }
    
    public virtual Team Team { get; set; }
    
    public virtual AppUser User { get; set; }
}