
namespace Dominio;

public class Provincia : BaseEntityA
{
    public ICollection<Persona> ?Personas { get; set; }

    public string ?NameProvincia { get; set; }
    public int ?IdRegion { get; set; }
    public Region ? Region { get; set; }

}
