namespace KunigiMuseum.Entities;

public class PuzzleMedia
{
    public Guid PuzzleMediaId { get; set; }
    
    public Guid PuzzleId { get; set; }
    
    public Guid MediaFileId { get; set; }
    
    public string MediaType { get; set; }
    
    public virtual Puzzle Puzzle { get; set; }
    
    public virtual MediaFile MediaFile { get; set; }
}