using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class ClientContactConfiguration : IEntityTypeConfiguration<ClientContact>
    {
        public void Configure(EntityTypeBuilder<ClientContact> builder)
        {
            builder.HasKey(cc => cc.ContactId);

            builder.Property(cc => cc.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(cc => cc.Title)
                .HasMaxLength(200);

            builder.Property(cc => cc.Email)
                .HasMaxLength(256);

            builder.Property(cc => cc.Phone)
                .HasMaxLength(20);

            builder.Property(cc => cc.Note)
                .HasMaxLength(1000);
        }
    }
}
