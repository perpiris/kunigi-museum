namespace KunigiMuseum.Entities;

public class ParentGameMedia
{
    public Guid ParentGameMediaId { get; set; }
    
    public Guid ParentGameId { get; set; }
    
    public Guid MediaFileId { get; set; }
    
    public virtual ParentGame ParentGame { get; set; }
    
    public virtual MediaFile MediaFile { get; set; }
}