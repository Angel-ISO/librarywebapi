using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        

    public void Configure(EntityTypeBuilder<Marca> builder)
    {
        builder.ToTable("Marcas");

        builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdMarcas")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.DescripcionEditorial)
            .HasColumnName("Descripcioneditorial")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();
        
    }
}