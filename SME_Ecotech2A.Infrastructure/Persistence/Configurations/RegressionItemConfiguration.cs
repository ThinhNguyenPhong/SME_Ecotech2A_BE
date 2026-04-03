using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class RegressionItemConfiguration : IEntityTypeConfiguration<RegressionItem>
    {
        public void Configure(EntityTypeBuilder<RegressionItem> builder)
        {
            builder.HasKey(ri => ri.RegressionItemId);

            builder.Property(ri => ri.TestCase)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(ri => ri.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(ri => ri.Note)
                .HasMaxLength(2000);

            builder.HasOne(ri => ri.VerifiedByUser)
                .WithMany()
                .HasForeignKey(ri => ri.VerifiedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
