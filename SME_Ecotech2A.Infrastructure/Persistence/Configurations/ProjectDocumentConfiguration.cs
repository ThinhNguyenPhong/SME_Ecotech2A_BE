using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class ProjectDocumentConfiguration : IEntityTypeConfiguration<ProjectDocument>
    {
        public void Configure(EntityTypeBuilder<ProjectDocument> builder)
        {
            builder.HasKey(pd => pd.DocumentId);

            builder.Property(pd => pd.DocType)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(pd => pd.DocName)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(pd => pd.FileUrl)
                .IsRequired()
                .HasMaxLength(1000);

            builder.HasOne(pd => pd.UploadedByUser)
                .WithMany(u => u.ProjectDocuments)
                .HasForeignKey(pd => pd.UploadedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
