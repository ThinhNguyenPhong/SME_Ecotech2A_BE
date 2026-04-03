using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;
using Task = SME_Ecotech2A.Domain.Entity.Task;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(t => t.TaskId);

            builder.Property(t => t.TaskCode)
                .HasMaxLength(50);

            builder.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(t => t.Description)
                .HasMaxLength(4000);

            builder.Property(t => t.TaskType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.Priority)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.DelayReasonType)
                .HasMaxLength(100);

            builder.HasMany(t => t.PredecessorDependencies)
                .WithOne(td => td.PredecessorTask)
                .HasForeignKey(td => td.PredecessorTaskId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(t => t.SuccessorDependencies)
                .WithOne(td => td.SuccessorTask)
                .HasForeignKey(td => td.SuccessorTaskId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(t => t.TaskProgressLogs)
                .WithOne(tpl => tpl.Task)
                .HasForeignKey(tpl => tpl.TaskId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(t => t.TimesheetEntries)
                .WithOne(ts => ts.Task)
                .HasForeignKey(ts => ts.TaskId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(t => t.TaskAttachments)
                .WithOne(ta => ta.Task)
                .HasForeignKey(ta => ta.TaskId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(t => t.ConflictEvents)
                .WithOne(ce => ce.Task)
                .HasForeignKey(ce => ce.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(t => t.BugTickets)
                .WithOne(bt => bt.Task)
                .HasForeignKey(bt => bt.TaskId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
