using KunigiMuseum.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KunigiMuseum.EntityConfiguration;

public class GameTypeConfiguration : IEntityTypeConfiguration<GameType>
{
    public void Configure(EntityTypeBuilder<GameType> builder)
    {
        builder.Property(x => x.GameTypeId)
            .HasColumnType("uuid")
            .HasDefaultValueSql("gen_random_uuid()");
        
        builder.Property(x => x.Description)
            .HasMaxLength(150)
            .IsRequired();
            
        builder.Property(x => x.Slug)
            .HasMaxLength(150)
            .IsRequired();
    }
}