namespace KunigiMuseum.ViewModels.Team;

public class TeamDetailsViewModel
{
    public Guid TeamId { get; set; }
    
    public string Name { get; set; }
    
    public string Slug { get; set; }
    
    public bool IsActive { get; set; }
    
    public short? FoundedYear { get; set; }

    public string Description { get; set; }

    public string WebsiteUrl { get; set; }

    public string FacebookUrl { get; set; }

    public string InstagramUrl { get; set; }

    public string YoutubeUrl { get; set; }
}