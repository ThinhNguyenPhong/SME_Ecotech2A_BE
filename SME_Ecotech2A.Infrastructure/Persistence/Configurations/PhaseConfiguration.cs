using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class PhaseConfiguration : IEntityTypeConfiguration<Phase>
    {
        public void Configure(EntityTypeBuilder<Phase> builder)
        {
            builder.HasKey(ph => ph.PhaseId);

            builder.Property(ph => ph.PhaseName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(ph => ph.PhaseType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(ph => ph.Description)
                .HasMaxLength(2000);

            builder.Property(ph => ph.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(ph => ph.BaselineAdjustmentLog)
                .HasMaxLength(2000);

            builder.HasMany(ph => ph.Milestones)
                .WithOne(m => m.Phase)
                .HasForeignKey(m => m.PhaseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(ph => ph.Tasks)
                .WithOne(t => t.Phase)
                .HasForeignKey(t => t.PhaseId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(ph => ph.ReviewSessions)
                .WithOne(rs => rs.Phase)
                .HasForeignKey(rs => rs.PhaseId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(ph => ph.BugTickets)
                .WithOne(bt => bt.Phase)
                .HasForeignKey(bt => bt.PhaseId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(ph => ph.SupportTickets)
                .WithOne(st => st.Phase)
                .HasForeignKey(st => st.PhaseId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
