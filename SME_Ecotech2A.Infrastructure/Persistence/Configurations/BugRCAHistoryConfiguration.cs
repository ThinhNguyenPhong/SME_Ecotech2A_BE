using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class BugRCAHistoryConfiguration : IEntityTypeConfiguration<BugRCAHistory>
    {
        public void Configure(EntityTypeBuilder<BugRCAHistory> builder)
        {
            builder.HasKey(br => br.RcaId);

            builder.Property(br => br.RootCauseType)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(br => br.RootCauseNote)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(br => br.Solution)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(br => br.PreventionAction)
                .IsRequired()
                .HasMaxLength(2000);

            builder.HasOne(br => br.BugTicket)
                .WithMany(bt => bt.BugRcaHistories)
                .HasForeignKey(br => br.BugId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(br => br.CreatedByUser)
                .WithMany(u => u.BugRcaHistories)
                .HasForeignKey(br => br.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
