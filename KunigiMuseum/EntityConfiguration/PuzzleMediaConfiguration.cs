using KunigiMuseum.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KunigiMuseum.EntityConfiguration;

public class PuzzleMediaConfiguration : IEntityTypeConfiguration<PuzzleMedia>
{
    public void Configure(EntityTypeBuilder<PuzzleMedia> builder)
    {
        builder.Property(x => x.PuzzleMediaId)
            .HasColumnType("uuid")
            .HasDefaultValueSql("gen_random_uuid()");
        
        builder.Property(x => x.MediaType)
            .HasMaxLength(1)
            .IsRequired();
            
        builder.HasOne(x => x.Puzzle)
            .WithMany(x => x.MediaFiles)
            .HasForeignKey(x => x.PuzzleId)
            .OnDelete(DeleteBehavior.Cascade);
            
        builder.HasOne(x => x.MediaFile)
            .WithMany(x => x.PuzzleMediaFiles)
            .HasForeignKey(x => x.MediaFileId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}