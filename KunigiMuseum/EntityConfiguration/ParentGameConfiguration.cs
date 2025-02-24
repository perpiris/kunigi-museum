using KunigiMuseum.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KunigiMuseum.EntityConfiguration;

public class ParentGameConfiguration : IEntityTypeConfiguration<ParentGame>
{
    public void Configure(EntityTypeBuilder<ParentGame> builder)
    {
        builder.Property(x => x.ParentGameId)
            .HasColumnType("uuid")
            .HasDefaultValueSql("gen_random_uuid()");
        
        builder.Property(x => x.MainTitle)
            .HasMaxLength(150)
            .IsRequired();
            
        builder.Property(x => x.SubTitle)
            .HasMaxLength(150);
            
        builder.Property(x => x.Description)
            .HasColumnType("text");
            
        builder.Property(x => x.Slug)
            .HasMaxLength(150)
            .IsRequired();
            
        builder.Property(x => x.ProfileImagePath)
            .HasMaxLength(255);
            
        builder.HasOne(x => x.Host)
            .WithMany(x => x.HostedGames)
            .HasForeignKey(x => x.HostId)
            .OnDelete(DeleteBehavior.Restrict);
            
        builder.HasOne(x => x.Winner)
            .WithMany(x => x.WonGames)
            .HasForeignKey(x => x.WinnerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}