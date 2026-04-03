using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.FullName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(u => u.HashPassword)
                .IsRequired()
                .HasMaxLength(512);

            builder.HasIndex(u => u.Email).IsUnique();

            builder.HasMany(u => u.OwnedProjects)
                .WithOne(p => p.Owner)
                .HasForeignKey(p => p.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.AssignedTasks)
                .WithOne(t => t.Assignee)
                .HasForeignKey(t => t.AssigneeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.AssignedByTasks)
                .WithOne(t => t.Assigner)
                .HasForeignKey(t => t.AssignerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.ReportedBugs)
                .WithOne(b => b.Reporter)
                .HasForeignKey(b => b.ReporterId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.AssignedBugs)
                .WithOne(b => b.Assignee)
                .HasForeignKey(b => b.AssigneeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.VerifiedBugs)
                .WithOne(b => b.VerifyByUser)
                .HasForeignKey(b => b.VerifyBy)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(u => u.ReportedSupportTickets)
                .WithOne(st => st.Reporter)
                .HasForeignKey(st => st.ReporterId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.AssignedSupportTickets)
                .WithOne(st => st.Assignee)
                .HasForeignKey(st => st.AssigneeId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
