
namespace Dominio;

public class TypePerson : BaseEntityA
{
    public ICollection<Persona> ?Personas { get; set; }

    public string ?Description { get; set; }
}
