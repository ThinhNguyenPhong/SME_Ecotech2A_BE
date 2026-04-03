using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.ProjectId);

            builder.Property(p => p.ProjectCode)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.ProjectName)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(p => p.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Priority)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Description)
                .HasMaxLength(2000);

            builder.HasIndex(p => p.ProjectCode).IsUnique();

            builder.HasMany(p => p.Phases)
                .WithOne(ph => ph.Project)
                .HasForeignKey(ph => ph.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Tasks)
                .WithOne(t => t.Project)
                .HasForeignKey(t => t.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.ProjectMembers)
                .WithOne(pm => pm.Project)
                .HasForeignKey(pm => pm.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.ProjectDocuments)
                .WithOne(pd => pd.Project)
                .HasForeignKey(pd => pd.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.ReviewSessions)
                .WithOne(rs => rs.Project)
                .HasForeignKey(rs => rs.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.BugTickets)
                .WithOne(bt => bt.Project)
                .HasForeignKey(bt => bt.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.SupportTickets)
                .WithOne(st => st.Project)
                .HasForeignKey(st => st.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.ConflictEvents)
                .WithOne(ce => ce.FromProject)
                .HasForeignKey(ce => ce.FromProjectId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
