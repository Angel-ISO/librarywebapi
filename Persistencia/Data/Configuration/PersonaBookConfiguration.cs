using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
    public class PersonaBookConfiguration : IEntityTypeConfiguration<PersonaBook>
    {
    public void Configure(EntityTypeBuilder<PersonaBook> builder)
    {
        builder.ToTable("PersonaBook");

            builder.Property(p => p.Id)
                .HasColumnName("Persona_Id")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(p => p.Persona)
                .WithMany(p => p.PersonaBooks)
                .HasForeignKey(p => p.Id);

            builder.Property(p => p.BookId)
                .HasColumnName("Libro_Id")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(p => p.book)
                .WithMany(p => p.PersonaBooks)
                .HasForeignKey(p => p.BookId);
    }
}