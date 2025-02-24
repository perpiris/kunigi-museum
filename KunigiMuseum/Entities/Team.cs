namespace KunigiMuseum.Entities;

public class Team
{
    public Guid TeamId { get; set; }
    
    public string Description { get; set; }
    
    public string Name { get; set; }
    
    public string Slug { get; set; }
    
    public short? FoundedYear { get; set; }
    
    public bool IsActive { get; set; }
    
    public string WebsiteUrl { get; set; }
    
    public string FacebookUrl { get; set; }
    
    public string YoutubeUrl { get; set; }
    
    public string InstagramUrl { get; set; }
    
    public string ProfileImagePath { get; set; }
    
    public virtual ICollection<ParentGame> HostedGames { get; set; }
    
    public virtual ICollection<ParentGame> WonGames { get; set; }
    
    public virtual ICollection<TeamManager> Managers { get; set; }
    
    public virtual ICollection<TeamMedia> MediaFiles { get; set; }
}