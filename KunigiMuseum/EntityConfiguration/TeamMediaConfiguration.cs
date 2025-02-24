using KunigiMuseum.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KunigiMuseum.EntityConfiguration;

public class TeamMediaConfiguration : IEntityTypeConfiguration<TeamMedia>
{
    public void Configure(EntityTypeBuilder<TeamMedia> builder)
    {
        builder.Property(x => x.TeamMediaId)
            .HasColumnType("uuid")
            .HasDefaultValueSql("gen_random_uuid()");
        
        builder.HasOne(x => x.Team)
            .WithMany(x => x.MediaFiles)
            .HasForeignKey(x => x.TeamId)
            .OnDelete(DeleteBehavior.Cascade);
            
        builder.HasOne(x => x.MediaFile)
            .WithMany(x => x.TeamMediaFiles)
            .HasForeignKey(x => x.MediaFileId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}