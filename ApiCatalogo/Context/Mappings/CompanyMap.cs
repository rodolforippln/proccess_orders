using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            //Tabela
            builder.ToTable("TB_Company");

            //Chave Primaria
            builder.HasKey(x => x.CompanyId);

            builder
                .Property(c => c.CompanyId)
                .HasColumnName("inCompanyId");

            builder.Property(x => x.ReceiverDocument)
                .HasColumnName("chReceiverDocument")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(x => x.ReceiverStateRegistration)
                .HasColumnName("chReceiverStateRegistration")
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(x => x.ReceiverName)
                .HasColumnName("chNome")
                .HasColumnType("varchar")
                .HasMaxLength(50);
        }
    }
}
