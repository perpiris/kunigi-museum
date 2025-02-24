namespace KunigiMuseum.Entities;

public class Game
{
    public Guid GameId { get; set; }
    
    public string Title { get; set; }
    
    public string Description { get; set; }

    public Guid GameTypeId { get; set; }
    
    public Guid ParentGameId { get; set; }
    
    public virtual GameType GameType { get; set; }
    
    public virtual ParentGame ParentGame { get; set; }
    
    public virtual ICollection<Puzzle> PuzzleList { get; set; }
}