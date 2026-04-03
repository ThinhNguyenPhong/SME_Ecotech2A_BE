using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.ClientId);

            builder.Property(c => c.ClientName)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(c => c.Industry)
                .HasMaxLength(200);

            builder.Property(c => c.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.TaxCode)
                .HasMaxLength(50);

            builder.Property(c => c.Website)
                .HasMaxLength(500);

            builder.Property(c => c.Address)
                .HasMaxLength(500);

            builder.Property(c => c.AvatarUrl)
                .HasMaxLength(1000);

            builder.Property(c => c.Note)
                .HasMaxLength(1000);

            builder.HasMany(c => c.ClientContacts)
                .WithOne(cc => cc.Client)
                .HasForeignKey(cc => cc.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.Projects)
                .WithOne(p => p.Client)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
