using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SME_Ecotech2A.Domain.Entity;

namespace SME_Ecotech2A.Infrastructure.Persistence.Configurations
{
    public class SupportTicketConfiguration : IEntityTypeConfiguration<SupportTicket>
    {
        public void Configure(EntityTypeBuilder<SupportTicket> builder)
        {
            builder.HasKey(st => st.SupportTicketId);

            builder.Property(st => st.TicketCode)
                .HasMaxLength(50);

            builder.Property(st => st.Title)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(st => st.Description)
                .IsRequired()
                .HasMaxLength(4000);

            builder.Property(st => st.Category)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(st => st.Priority)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(st => st.Status)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
