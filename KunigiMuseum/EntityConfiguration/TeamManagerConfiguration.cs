using KunigiMuseum.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KunigiMuseum.EntityConfiguration;

public class TeamManagerConfiguration : IEntityTypeConfiguration<TeamManager>
{
    public void Configure(EntityTypeBuilder<TeamManager> builder)
    {
        builder.Property(x => x.TeamManagerId)
            .HasColumnType("uuid")
            .HasDefaultValueSql("gen_random_uuid()");
        
        builder.HasOne(x => x.Team)
            .WithMany(x => x.Managers)
            .HasForeignKey(x => x.TeamId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}