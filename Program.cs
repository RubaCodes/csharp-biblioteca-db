﻿using System.Data.SqlClient;

string stringaDiConnessione = "Data Source=localhost;Initial Catalog=db-biblioteca;Integrated Security=True";

SqlConnection connection = new SqlConnection(stringaDiConnessione);
// inseriamo un prodotto nelal tabella prodotti
try
{
    connection.Open();
    Console.WriteLine("Connessione Aperta");
    string query = "INSERT INTO Products (SerialCode,Title, Year, Media_type) VALUES (@codice_seriale , @titolo , @anno, @media)";
    SqlCommand cmd = new SqlCommand(query, connection);
    cmd.Parameters.Add(new SqlParameter("@codice_seriale", "213kb12b3123k"));
    cmd.Parameters.Add(new SqlParameter("@titolo", "Harry Potter e la pietra filosofale"));
    cmd.Parameters.Add(new SqlParameter("@anno", "2001"));
    cmd.Parameters.Add(new SqlParameter("@media", "Book"));

    int affectedRows = cmd.ExecuteNonQuery();
}
catch(SqlException ex)
{
    Console.WriteLine(ex.Message);
}
finally {
    connection.Close();
    Console.WriteLine("Connessione Chiusa");
}


//nuova biblioteca
//Biblioteca bibilioteca = new Biblioteca();
////nuovo user
//User userRegistrato = new User("Paolo", "Verdi", "lamiamail@mail.com","password", 1234561234);
//User userNonRegistrato = new User("Rossi", "Marco", "lamiamail@mail.com", "password", 1234561234);
////aggiunta user
//bibilioteca.AddNewUser(userRegistrato);
////nuovo libro
//Book nuovoLibro = new Book("ad1231312fsd", "Harry Potter e la pietra filosofale");
////Test Getter e Setter Nuovo Libro
//nuovoLibro.Pagine = 750;
//Console.WriteLine(nuovoLibro.Title);
//Console.WriteLine(nuovoLibro.Pagine);
////nuovo film
//Movie nuovoFilm = new Movie("ad65452342fsd", "Superman: il grande super eroe.");
////test getter e setter nuovo film
//nuovoFilm.Durata = 98;
//Console.WriteLine(nuovoFilm.Title);
//Console.WriteLine(nuovoFilm.Durata);
//nuovoFilm.AuthorLastName = "Rossi";
//nuovoFilm.AuthorFirstName = "Mario";
////test full name autore
//Console.WriteLine(nuovoFilm.FullAuthorName);
////aggiunti prodotti alla biblioteca
//bibilioteca.AddMovie(nuovoFilm);
//bibilioteca.AddBook(nuovoLibro);
////risultati di ricerca
//List<Product> risultati = bibilioteca.SearchProduct("harry");
//Console.WriteLine(risultati[0].Title);
////test prestito

//bibilioteca.NuovoPrestito(nuovoFilm, userRegistrato, DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now));
////se provo a effettuare un nuovo prestito con un utente non registrato , esso non viene creato
//bibilioteca.NuovoPrestito(nuovoFilm, userNonRegistrato, DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now));
////test ricerca prestito, funzionante a meno di controlli
//Console.WriteLine("Nome del prestito");
//string nomeRicerca = Console.ReadLine();
//Console.WriteLine("Cognome del prestito");

//string cognomeRicerca = Console.ReadLine();

//var ricercaPrestiti = bibilioteca.CercaPrestito(nomeRicerca, cognomeRicerca);

//if (ricercaPrestiti.Count > 0) { 
//    foreach(Prestito el in ricercaPrestiti)
//    {
//        Console.WriteLine(el.User.FirstName + " " + el.User.LastName);
//        Console.WriteLine("Durata");
//        Console.WriteLine(el.dataInizio);
//        Console.WriteLine(el.dataFine);
//    }
//}
//else Console.WriteLine("Nessun prestito registrato con quel nome utente");
