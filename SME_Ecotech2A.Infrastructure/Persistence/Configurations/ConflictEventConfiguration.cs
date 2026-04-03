using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class ConflictEventConfiguration : IEntityTypeConfiguration<ConflictEvent>
    {
        public void Configure(EntityTypeBuilder<ConflictEvent> builder)
        {
            builder.HasKey(ce => ce.ConflictEventId);

            builder.Property(ce => ce.ConflictType)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(ce => ce.ConflictNote)
                .HasMaxLength(1000);

            builder.HasOne(ce => ce.User)
                .WithMany(u => u.ConflictEvents)
                .HasForeignKey(ce => ce.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
