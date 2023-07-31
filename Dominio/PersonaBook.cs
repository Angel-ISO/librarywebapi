using System.Diagnostics.Eventing.Reader;

namespace Dominio;

public class PersonaBook : BaseEntityA
{
    public Persona ?Persona { get; set; }
    public int BookId { get; set; }
    public Book ? book { get; set; }
}
