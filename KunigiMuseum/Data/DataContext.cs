using KunigiMuseum.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KunigiMuseum.Data;

public class DataContext : IdentityDbContext<AppUser>
{
    public DbSet<AppUser> AppUsers { get; set; }
    
    public DbSet<Game> Games { get; set; }
    
    public DbSet<GameType> GameTypes { get; set; }
    
    public DbSet<MediaFile> MediaFiles { get; set; }
    
    public DbSet<ParentGame> ParentGames { get; set; }
    
    public DbSet<ParentGameMedia> ParentGameMedia { get; set; }
    
    public DbSet<Puzzle> Puzzles { get; set; }
    
    public DbSet<PuzzleMedia> PuzzleMedia { get; set; }
    
    public DbSet<Team> Teams { get; set; }
    
    public DbSet<TeamManager> TeamManagers { get; set; }
    
    public DbSet<TeamMedia> TeamMedia { get; set; }
    
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
    }
}