using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class ProvinciaConfiguration : IEntityTypeConfiguration<Provincia>
    {
    public void Configure(EntityTypeBuilder<Provincia> builder)
    {
        builder.ToTable("Provincias");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("IdProvincia")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.NameProvincia)
                .HasColumnName("NombreProvincia")
                .HasColumnType("varchar")
                .HasMaxLength(70)
                .IsRequired();
            
            builder.Property(p => p.IdRegion)
                .HasColumnName("Region_Id")
                .HasColumnType("int")
                .IsRequired();
            
            builder.HasOne(p => p.Region)
                .WithMany(p => p.Provincias)
                .HasForeignKey(p => p.IdRegion);
    }
}