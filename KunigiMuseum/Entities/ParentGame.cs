namespace KunigiMuseum.Entities;

public class ParentGame
{
    public Guid ParentGameId { get; set; }

    public short Year { get; set; }

    public short Order { get; set; }
    
    public string MainTitle { get; set; }
    
    public string SubTitle { get; set; }
    
    public string Description { get; set; }
    
    public string Slug { get; set; }
    
    public string ProfileImagePath { get; set; }
    
    public Guid HostId { get; set; }
    
    public Guid WinnerId { get; set; }
    
    public virtual Team Host { get; set; }
    
    public virtual Team Winner { get; set; }
    
    public virtual ICollection<Game> Games { get; set; }
    
    public virtual ICollection<ParentGameMedia> MediaFiles { get; set; }
}