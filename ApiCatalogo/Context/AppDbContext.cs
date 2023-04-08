using ApiCatalogo.Models;
using Blog.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Volume>? Volumes { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Company>? Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new VolumeMap());
        }

        //protected override void OnModelCreating(ModelBuilder mb)
        //{
        //    //Order
        //    mb.Entity<Categoria>().HasKey(c => c.CategoriaId);

        //    mb.Entity<Categoria>()
        //        .Property(c=> c.Nome)
        //        .HasMaxLength(100)
        //        .IsRequired();

        //    mb.Entity<Categoria>()
        //        .Property(c => c.Descricao)
        //        .HasMaxLength(150);

        //    //Produto
        //    mb.Entity<Produto>()
        //        .HasKey(c => c.ProdutoId);

        //    mb.Entity<Produto>()
        //        .Property(c => c.Nome)
        //        .HasMaxLength(100);



        //    //relacionamento
        //    mb.Entity<Produto>()
        //        .HasOne(c=> c.Categoria)
        //          .WithMany(p=> p.Produtos)
        //            .HasForeignKey(c => c.CategoriaId).OnDelete(DeleteBehavior.Cascade);
        //}
    }
}
