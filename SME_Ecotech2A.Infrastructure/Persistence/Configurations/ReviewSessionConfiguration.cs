using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class ReviewSessionConfiguration : IEntityTypeConfiguration<ReviewSession>
    {
        public void Configure(EntityTypeBuilder<ReviewSession> builder)
        {
            builder.HasKey(rs => rs.ReviewId);

            builder.Property(rs => rs.ReviewType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(rs => rs.Status)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
