
//nuova biblioteca
Bibilioteca bibilioteca = new Bibilioteca();
//nuovo user
User userRegistrato = new User("Marcon", "Alberto", "lamiamail@mail.com","password", 1234561234);
User userNonRegistrato = new User("Rossi", "Marco", "lamiamail@mail.com", "password", 1234561234);
//aggiunta user
bibilioteca.AddNewUser(userRegistrato);
//nuovo libro
Book nuovoLibro = new Book("ad1231312fsd", "Harry Potter e la pietra filosofale");
//Test Getter e Setter Nuovo Libro
nuovoLibro.Pagine = 750;
Console.WriteLine(nuovoLibro.Title);
Console.WriteLine(nuovoLibro.Pagine);
//nuovo film
Movie nuovoFilm = new Movie("ad65452342fsd", "Superman: il grande super eroe.");
//test getter e setter nuovo film
nuovoFilm.Durata = 98;
Console.WriteLine(nuovoFilm.Title);
Console.WriteLine(nuovoFilm.Durata);
nuovoFilm.AuthorLastName = "Rossi";
nuovoFilm.AuthorFirstName = "Mario";
//test full name autore
Console.WriteLine(nuovoFilm.FullAuthorName);
//aggiunti prodotti alla biblioteca
bibilioteca.AddMovie(nuovoFilm);
bibilioteca.AddBook(nuovoLibro);
//risultati di ricerca
List<Product> risultati = bibilioteca.SearchProduct("harry");
Console.WriteLine(risultati[0].Title);
//test prestito

bibilioteca.NuovoPrestito(nuovoFilm, userRegistrato, DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now));
//se provo a effettuare un nuovo prestito con un utente non registrato , esso non viene creato
bibilioteca.NuovoPrestito(nuovoFilm, userNonRegistrato, DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now));
//test ricerca prestito, funzionante a meno di controlli
Console.WriteLine("Nome del prestito");
string nomeRicerca = Console.ReadLine();
Console.WriteLine("Cognome del prestito");

string cognomeRicerca = Console.ReadLine();

var ricercaPrestiti = bibilioteca.CercaPrestito(nomeRicerca, cognomeRicerca);

if (ricercaPrestiti.Count > 0) { 
    foreach(Prestito el in ricercaPrestiti)
    {
        Console.WriteLine(el.User.FirstName + " " + el.User.LastName);
        Console.WriteLine("Durata");
        Console.WriteLine(el.dataInizio);
        Console.WriteLine(el.dataFine);
    }
}
else Console.WriteLine("Nessun prestito registrato con quel nome utente");
//#region Wip
//bool continua = true;
//while (continua)
//{

//    Console.WriteLine("----Cosa vuoi fare?----");
//    Console.WriteLine("1 - Iscriviti; 2 - Cerca un Prodotto; 0-esci dall'applicativo");
//    int condition = Convert.ToInt32(Console.ReadLine());

//    switch (condition)
//    {
//        case 0:
//            continua = false;
//            break;
//        case 1:
//            Console.WriteLine("Inserisci il tuo nome");
//            string nome = Console.ReadLine();
//            Console.WriteLine("Inserisci il tuo cognome");
//            string cognome = Console.ReadLine();
//            Console.WriteLine("Inserisci la tua email");
//            string email = Console.ReadLine();
//            Console.WriteLine("Inserisci la tua password");
//            string password = Console.ReadLine();
//            Console.WriteLine("Inserisci il tuo numero di telefono");
//            double telefono = Convert.ToDouble(Console.ReadLine());
//            bibilioteca.AddNewUser(new User(cognome, nome, email, password, telefono));
//            break;
//        case 2:
//            Console.WriteLine("Inserisci il nome del prodotto da cercare:");
//            string prodottoSearch = Console.ReadLine();
//            List<Product> risultatiSearch = bibilioteca.SearchProduct(prodottoSearch);
//            if (risultatiSearch.Count == 0)
//            {
//                Console.WriteLine("Spiacente, nessun risultato trovato");
//            }
//            else {
//                foreach (Product el in risultatiSearch)
//                {
//                    Console.WriteLine("Nome e codice identificativo");
//                    Console.WriteLine(el.Title + " " + el.SerialCode);
//                    Console.WriteLine("Categoria");
//                    Console.WriteLine(el.Category);

//                }
//            }
//            break;

//    }

//    #endregion
//}