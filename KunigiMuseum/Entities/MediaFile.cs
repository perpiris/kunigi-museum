namespace KunigiMuseum.Entities;

public class MediaFile
{
    public Guid MediaFileId { get; set; }
    
    public string Path { get; set; }
    
    public virtual ICollection<TeamMedia> TeamMediaFiles { get; set; }
    
    public virtual ICollection<ParentGameMedia> ParentGameMediaFiles { get; set; }
    
    public virtual ICollection<PuzzleMedia> PuzzleMediaFiles { get; set; }
}