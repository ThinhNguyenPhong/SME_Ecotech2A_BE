using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class MilestoneConfiguration : IEntityTypeConfiguration<Milestone>
    {
        public void Configure(EntityTypeBuilder<Milestone> builder)
        {
            builder.HasKey(m => m.MilestoneId);

            builder.Property(m => m.MilestoneName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(m => m.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany(m => m.ReviewSessions)
                .WithOne(rs => rs.Milestone)
                .HasForeignKey(rs => rs.MilestoneId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
