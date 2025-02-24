using KunigiMuseum.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KunigiMuseum.EntityConfiguration;

public class PuzzleConfiguration : IEntityTypeConfiguration<Puzzle>
{
    public void Configure(EntityTypeBuilder<Puzzle> builder)
    {
        builder.Property(x => x.PuzzleId)
            .HasColumnType("uuid")
            .HasDefaultValueSql("gen_random_uuid()");
        
        builder.Property(x => x.Question)
            .HasColumnType("text")
            .IsRequired();
            
        builder.Property(x => x.Answer)
            .HasColumnType("text")
            .IsRequired();
            
        builder.HasOne(x => x.Game)
            .WithMany(x => x.PuzzleList)
            .HasForeignKey(x => x.GameId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}