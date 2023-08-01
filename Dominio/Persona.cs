

namespace Dominio;

public class Persona : BaseEntityA
{

    public ICollection<PersonaBook> ?PersonaBooks { get; set; }

    public string? NamePerson { get; set; }
    public string ?LastName { get; set; }
    public int  Age { get; set; }
    public int IdProvincia { get; set; }
    public Provincia ? Provincia { get; set; }
    public int IdTypePerson { get; set; }
    public TypePerson ? TypePerson { get; set; }


 
}
