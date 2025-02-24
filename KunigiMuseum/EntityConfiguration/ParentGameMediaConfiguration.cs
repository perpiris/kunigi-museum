using KunigiMuseum.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KunigiMuseum.EntityConfiguration;

public class ParentGameMediaConfiguration : IEntityTypeConfiguration<ParentGameMedia>
{
    public void Configure(EntityTypeBuilder<ParentGameMedia> builder)
    {
        builder.Property(x => x.ParentGameMediaId)
            .HasColumnType("uuid")
            .HasDefaultValueSql("gen_random_uuid()");
        
        builder.HasOne(x => x.ParentGame)
            .WithMany(x => x.MediaFiles)
            .HasForeignKey(x => x.ParentGameId)
            .OnDelete(DeleteBehavior.Cascade);
            
        builder.HasOne(x => x.MediaFile)
            .WithMany(x => x.ParentGameMediaFiles)
            .HasForeignKey(x => x.MediaFileId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}