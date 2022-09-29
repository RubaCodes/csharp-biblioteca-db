
public class Prestito
{
    public Product ProductType { get; set; }
    public User User { get; set; }
    public DateOnly dataInizio { get; set; }
    public DateOnly dataFine { get; set; }

    public Prestito(Product productType, User user, DateOnly dataInizio, DateOnly dataFine)
    {   
        ProductType = productType;
        User = user;
        this.dataInizio = dataInizio;
        this.dataFine = dataFine;
    }
}