using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class TaskAttachmentConfiguration : IEntityTypeConfiguration<TaskAttachment>
    {
        public void Configure(EntityTypeBuilder<TaskAttachment> builder)
        {
            builder.HasKey(ta => ta.AttachmentId);

            builder.Property(ta => ta.FileName)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(ta => ta.FileUrl)
                .IsRequired()
                .HasMaxLength(1000);

            builder.HasOne(ta => ta.UploadedByUser)
                .WithMany(u => u.TaskAttachments)
                .HasForeignKey(ta => ta.UploadedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
