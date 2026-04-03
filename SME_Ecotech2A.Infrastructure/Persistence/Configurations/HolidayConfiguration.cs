using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class HolidayConfiguration : IEntityTypeConfiguration<Holiday>
    {
        public void Configure(EntityTypeBuilder<Holiday> builder)
        {
            builder.HasKey(h => h.HolidayId);

            builder.Property(h => h.HolidayName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(h => h.HolidayType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(h => h.Note)
                .HasMaxLength(500);
        }
    }
}
