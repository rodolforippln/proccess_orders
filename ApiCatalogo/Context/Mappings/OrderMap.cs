using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            //Tabela
            builder.ToTable("TB_Order");

            //Chave Primária
            //order
            builder
                .HasKey(c => c.OrderId);

            builder
                .Property(c => c.OrderId)
                .HasColumnName("chOrderId")
                .HasMaxLength(36)
                .IsRequired();

            builder
                .Property(c => c.OriginPointCode)
                .HasColumnName("chOriginPointCode")
                .HasMaxLength(36);
            builder
                .Property(c => c.OriginPartnerPointCode)
                .HasColumnName("chOriginPartnerPointCode")
                .HasMaxLength(36);
            builder
                .Property(c => c.OriginPostalCode)
                .HasColumnName("chOriginPostalCode")
                .HasMaxLength(36);

            //// Índices
            //builder
            //    .HasIndex(x => x.Nome, "IX_Order_Name")
            //    .IsUnique();

            //Relacionamento com Company
            builder
                .HasOne(x => x.Company)
                .WithMany(x => x.Orders)
                .HasConstraintName("FK_Order_Company")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}