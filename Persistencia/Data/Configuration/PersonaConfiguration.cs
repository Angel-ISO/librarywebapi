using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("Personas");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("IdMarcas")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.NamePerson)
                .HasColumnName("Nombre")
                .HasColumnType("varchar")
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(p => p.LastName)
                .HasColumnName("Apellido")
                .HasColumnType("varchar")
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(p => p.Age)
                .HasColumnName("Edad")
                .HasColumnType("int")
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(p => p.IdProvincia)
                .HasColumnName("Provincia_Id")
                .HasColumnType("int")
                .IsRequired();
            
            builder.HasOne(p => p.Provincia)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdProvincia);

            builder.Property(p => p.IdTypePerson)
                .HasColumnName("TipoPersona_Id")
                .HasColumnType("int")
                .IsRequired();
            
            builder.HasOne(p => p.TypePerson)
                .WithMany(p => p.Personas)
                .HasForeignKey(p => p.IdTypePerson);
    }
}