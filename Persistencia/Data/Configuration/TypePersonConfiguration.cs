using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class TipoPersonaConfiguration : IEntityTypeConfiguration<TypePerson>
    {
    public void Configure(EntityTypeBuilder<TypePerson> builder)
    {
        builder.ToTable("TipoDePersonas");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("IdTipoPersona")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnName("DescripcionTipoPersona")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
    }
}