// See https://aka.ms/new-console-template for more information
public class Bibilioteca {
    //lista utenti registrati
     protected List<User> RegisterdUsers = new List<User>();
    //lista film 
    protected List<Movie> Movies = new List<Movie>();
    //lista Libri
    protected List<Book> Books = new List<Book>();
    //lista di prestiti
    protected List<Prestito> Prestiti = new List<Prestito>();
    //aggiungi e rimuove utente dalla lista
    public void AddNewUser(User utente) {
        utente.Registrato = true;
        RegisterdUsers.Add(utente);
        
    }
    public void RemoveUser(User utente)
    {
        RegisterdUsers.Remove(utente);
    }
    //aggiungi o rimuovi film dalla biblioteca
    public void AddMovie(Movie movie) {
        Movies.Add(movie);
    }
    public void RemoveMovie(Movie movie) {
        Movies.Remove(movie);
    }
    //aggiungi o rimuovi Libro dalla biglioteca
    public void AddBook(Book book) {
        Books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }
    //ricerca per utente
    public List<Product> SearchProduct(string titolo) {
        List<Product> risultati = new List<Product>();
        foreach (Movie movie in Movies)
        {
            if (movie.Title.ToLower().Contains(titolo.ToLower()))
            {
                risultati.Add(movie);
            }
        }
        foreach (Book book in Books) { 
            if (book.Title.ToLower().Contains(titolo.ToLower()))
            {
               risultati.Add(book);
            }
        }
        return risultati;
    }
    public void NuovoPrestito(Product prodotto, User utente, DateOnly inizio, DateOnly fine) {
        if (utente.Registrato == false) return;
        Prestito nuovoPresito = new Prestito(prodotto, utente, DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(10)));
        Prestiti.Add(nuovoPresito);
    }
    public List<Prestito> CercaPrestito(string nome, string cognome) {
        List<Prestito> risultati = new List<Prestito>();
        foreach (Prestito el in Prestiti) {
            if (el.User.FirstName.ToLower() + el.User.LastName.ToLower() == nome.ToLower() + cognome.ToLower()) {
                risultati.Add(el);
            }
        }
        //if (risultati.Count == 0) return Console.WriteLine("Nessun risultato trovato");
        return risultati;
    }
}