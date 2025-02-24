namespace KunigiMuseum.Entities;

public class TeamMedia
{
    public Guid TeamMediaId { get; set; }
    
    public Guid TeamId { get; set; }
    
    public Guid MediaFileId { get; set; }
    
    public virtual Team Team { get; set; }
    
    public virtual MediaFile MediaFile { get; set; }
}