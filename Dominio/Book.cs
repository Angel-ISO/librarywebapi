

namespace Dominio;

public class Book : BaseEntityA
{
     public ICollection<PersonaBook> ?PersonaBooks { get; set; }

    public string ?RefBook { get; set; }
    public string ?DescripcionBook { get; set; }
    public double  PriceBook { get; set; }
    public double DctoBook { get; set; }
    public int MarcaId { get; set; }
    public Marca ? Marca { get; set; }

}
