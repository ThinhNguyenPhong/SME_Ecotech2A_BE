using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class BugTicketConfiguration : IEntityTypeConfiguration<BugTicket>
    {
        public void Configure(EntityTypeBuilder<BugTicket> builder)
        {
            builder.HasKey(bt => bt.BugId);

            builder.Property(bt => bt.BugCode)
                .HasMaxLength(50);

            builder.Property(bt => bt.Title)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(bt => bt.Description)
                .IsRequired()
                .HasMaxLength(4000);

            builder.Property(bt => bt.StepsToReproduce)
                .HasMaxLength(4000);

            builder.Property(bt => bt.Environment)
                .HasMaxLength(50);

            builder.Property(bt => bt.Severity)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(bt => bt.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(bt => bt.RootCauseType)
                .HasMaxLength(100);

            builder.HasMany(bt => bt.RegressionItems)
                .WithOne(ri => ri.BugTicket)
                .HasForeignKey(ri => ri.BugId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
