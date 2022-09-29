
//nuova biblioteca
//nuovo user
//aggiunta user
//nuovo libro
//Test Getter e Setter Nuovo Libro
//nuovo film
//test getter e setter nuovo film
//test full name autore
//aggiunti prodotti alla biblioteca
//risultati di ricerca
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