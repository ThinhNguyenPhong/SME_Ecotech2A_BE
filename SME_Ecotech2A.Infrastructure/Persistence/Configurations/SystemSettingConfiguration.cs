using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class SystemSettingConfiguration : IEntityTypeConfiguration<SystemSetting>
    {
        public void Configure(EntityTypeBuilder<SystemSetting> builder)
        {
            builder.HasKey(ss => ss.SettingId);

            builder.Property(ss => ss.Category)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(ss => ss.Label)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(ss => ss.Value)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasIndex(ss => new { ss.Category, ss.Value }).IsUnique();
        }
    }
}
