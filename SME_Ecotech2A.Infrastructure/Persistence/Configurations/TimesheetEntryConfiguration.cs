using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class TimesheetEntryConfiguration : IEntityTypeConfiguration<TimesheetEntry>
    {
        public void Configure(EntityTypeBuilder<TimesheetEntry> builder)
        {
            builder.HasKey(ts => ts.TimesheetId);

            builder.Property(ts => ts.WorkType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(ts => ts.Hours)
                .HasColumnType("decimal(5,2)");

            builder.Property(ts => ts.HoursOT)
                .HasColumnType("decimal(5,2)");

            builder.HasOne(ts => ts.User)
                .WithMany(u => u.TimesheetEntries)
                .HasForeignKey(ts => ts.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ts => ts.ConflictEvent)
                .WithMany(ce => ce.TimesheetEntries)
                .HasForeignKey(ts => ts.ConflictEventId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
