using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class VolumeMap : IEntityTypeConfiguration<Volume>
    {
        public void Configure(EntityTypeBuilder<Volume> builder)
        {
            //Tabela
            builder.ToTable("TB_Volume");

            //Chave Primária
            //Volume
            builder
                .HasKey(c => c.VolumeId);

            builder
                .Property(c => c.VolumeId)
                .HasColumnName("inVolumeId");

            builder
                .Property(c => c.Pieces)
                .HasColumnName("nuPieces")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder
                .Property(c => c.Weight)
                .HasColumnName("nuWeight")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder
                .Property(c => c.Lenght)
                .HasColumnName("nuLenght")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder
                .Property(c => c.Width)
                .HasColumnName("nuWidth")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder
                .Property(c => c.Height)
                .HasColumnName("nuHeight")
                .HasColumnType("varchar")
                .HasMaxLength(100);

            //Relacionamento com Categiria
            builder
                .HasOne(c => c.Order)
                .WithMany(p => p.Volumes)
                .HasConstraintName("FK_Volume_Order")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}