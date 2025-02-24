using KunigiMuseum.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KunigiMuseum.EntityConfiguration;

public class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.Property(x => x.TeamId)
            .HasColumnType("uuid")
            .HasDefaultValueSql("gen_random_uuid()");
        
        builder.Property(x => x.Description)
            .HasColumnType("text");
            
        builder.Property(x => x.Name)
            .HasMaxLength(150)
            .IsRequired()
            .UseCollation("el-GR-x-icu");
            
        builder.Property(x => x.Slug)
            .HasMaxLength(150)
            .IsRequired();
            
        builder.Property(x => x.WebsiteUrl)
            .HasMaxLength(150);
            
        builder.Property(x => x.FacebookUrl)
            .HasMaxLength(150);
            
        builder.Property(x => x.YoutubeUrl)
            .HasMaxLength(150);
            
        builder.Property(x => x.InstagramUrl)
            .HasMaxLength(150);
            
        builder.Property(x => x.ProfileImagePath)
            .HasMaxLength(255);
    }
}