using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class TaskProgressLogConfiguration : IEntityTypeConfiguration<TaskProgressLog>
    {
        public void Configure(EntityTypeBuilder<TaskProgressLog> builder)
        {
            builder.HasKey(tpl => tpl.ProgressLogId);

            builder.Property(tpl => tpl.WorkContent)
                .HasMaxLength(2000);

            builder.Property(tpl => tpl.HoursLogged)
                .HasColumnType("decimal(5,2)");

            builder.Property(tpl => tpl.HoursOTLogged)
                .HasColumnType("decimal(5,2)");

            builder.Property(tpl => tpl.BlockerReason)
                .HasMaxLength(200);

            builder.Property(tpl => tpl.DelayReasonType)
                .HasMaxLength(100);

            builder.Property(tpl => tpl.DelayReasonNote)
                .HasMaxLength(1000);

            builder.Property(tpl => tpl.Note)
                .HasMaxLength(2000);

            builder.HasOne(tpl => tpl.UpdatedByUser)
                .WithMany(u => u.TaskProgressLogs)
                .HasForeignKey(tpl => tpl.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
