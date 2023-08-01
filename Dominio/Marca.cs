namespace Dominio;

public class Marca : BaseEntityA
{
    public string ? DescripcionEditorial {get; set;}
    public ICollection<Book> ? Books { get; set; }
}
