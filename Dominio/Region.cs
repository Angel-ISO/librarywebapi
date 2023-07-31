

namespace Dominio;

public class Region : BaseEntityA
{
    public ICollection<Provincia> ?Provincias { get; set; }

    public string? NameRegion { get; set; }
    public int IdPais { get; set; }
    public Pais ? Pais { get; set; }
}
