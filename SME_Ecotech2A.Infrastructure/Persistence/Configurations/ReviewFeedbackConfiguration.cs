using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class ReviewFeedbackConfiguration : IEntityTypeConfiguration<ReviewFeedback>
    {
        public void Configure(EntityTypeBuilder<ReviewFeedback> builder)
        {
            builder.HasKey(rf => rf.FeedbackId);

            builder.Property(rf => rf.FeedbackType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(rf => rf.Severity)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(rf => rf.Description)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(rf => rf.ActionStatus)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(rf => rf.ReviewSession)
                .WithMany(rs => rs.ReviewFeedbacks)
                .HasForeignKey(rf => rf.ReviewId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(rf => rf.Assignee)
                .WithMany(u => u.ReviewFeedbacks)
                .HasForeignKey(rf => rf.AssigneeId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
