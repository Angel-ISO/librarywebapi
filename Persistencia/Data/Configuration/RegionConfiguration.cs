using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("Regiones");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("IdRegion")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.NameRegion)
                .HasColumnName("NombreRegion")
                .HasColumnType("varchar")
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(p => p.IdPais)
                .HasColumnName("Pais_Id")
                .HasColumnType("int")
                .IsRequired();
            
            builder.HasOne(p => p.Pais)
                .WithMany(p => p.Regions)
                .HasForeignKey(p => p.IdPais);
    }
}