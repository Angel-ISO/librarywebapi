namespace Dominio;

public class Pais : BaseEntityA
{
    public ICollection<Region> ?Regions { get; set; }
    public string ? NameCountry { get; set; }
}

