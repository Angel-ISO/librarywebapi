using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Libros");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("IdProducto")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.RefBook)
                .HasColumnName("RefProducto")
                .HasColumnType("varchar")
                .HasMaxLength(70)
                .IsRequired();

             builder.Property(p => p.DescripcionBook)
                .HasColumnName("DescripcionProducto")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.PriceBook)
                .HasColumnName("PrecioProducto")
                .HasColumnType("double")
                .IsRequired();

            builder.Property(p => p.DctoBook)
                .HasColumnName("DctoProducto")
                .HasColumnType("double")
                .IsRequired();

            builder.Property(p => p.MarcaId)
                .HasColumnName("Marca_Id")
                .HasColumnType("int")
                .IsRequired();
            
            builder.HasOne(p => p.Marca)
                .WithMany(p => p.Books)
                .HasForeignKey(p => p.MarcaId);
    }
}