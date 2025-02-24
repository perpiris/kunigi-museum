using KunigiMuseum.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KunigiMuseum.EntityConfiguration;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.Property(x => x.GameId)
            .HasColumnType("uuid")
            .HasDefaultValueSql("gen_random_uuid()");
        
        builder.Property(x => x.Title)
            .HasMaxLength(150)
            .IsRequired();
            
        builder.Property(x => x.Description)
            .HasColumnType("text");
            
        builder.HasOne(x => x.GameType)
            .WithMany()
            .HasForeignKey(x => x.GameTypeId)
            .OnDelete(DeleteBehavior.Restrict);
            
        builder.HasOne(x => x.ParentGame)
            .WithMany(x => x.Games)
            .HasForeignKey(x => x.ParentGameId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}