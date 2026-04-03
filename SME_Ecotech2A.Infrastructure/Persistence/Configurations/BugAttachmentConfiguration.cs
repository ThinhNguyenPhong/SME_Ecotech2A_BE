using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class BugAttachmentConfiguration : IEntityTypeConfiguration<BugAttachment>
    {
        public void Configure(EntityTypeBuilder<BugAttachment> builder)
        {
            builder.HasKey(ba => ba.AttachmentId);

            builder.Property(ba => ba.FileName)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(ba => ba.FileUrl)
                .IsRequired()
                .HasMaxLength(1000);

            builder.HasOne(ba => ba.BugTicket)
                .WithMany(bt => bt.BugAttachments)
                .HasForeignKey(ba => ba.BugId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ba => ba.UploadedByUser)
                .WithMany(u => u.BugAttachments)
                .HasForeignKey(ba => ba.UploadedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
