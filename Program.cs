using System.Data.SqlClient;

string stringaDiConnessione = "Data Source=localhost;Initial Catalog=db-biblioteca;Integrated Security=True";

SqlConnection connection = new SqlConnection(stringaDiConnessione);
// inseriamo un prodotto nella tabella prodotti
//try
//{
//    connection.Open();
//    Console.WriteLine("Connessione Aperta");
//    string query = "INSERT INTO Products (SerialCode,Title, Year, Media_type) VALUES (@codice_seriale , @titolo , @anno, @media)";
//    SqlCommand cmd = new SqlCommand(query, connection);
//    cmd.Parameters.Add(new SqlParameter("@codice_seriale", "213kb12b3123k"));
//    cmd.Parameters.Add(new SqlParameter("@titolo", "Harry Potter e la pietra filosofale"));
//    cmd.Parameters.Add(new SqlParameter("@anno", "2001"));
//    cmd.Parameters.Add(new SqlParameter("@media", "Book"));

//    int affectedRows = cmd.ExecuteNonQuery();
//}
//catch(SqlException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally {
//    connection.Close();
//    Console.WriteLine("Connessione Chiusa");
//}

//UPDATE RECORD
//try
//{
//    connection.Open();
//    Console.WriteLine("Connessione Aperta");
//    string query = "UPDATE Products SET Media_type=@media WHERE Year = @anno;";
//    SqlCommand cmd = new SqlCommand(query, connection);
//    cmd.Parameters.Add(new SqlParameter("@anno", "2001"));
//    cmd.Parameters.Add(new SqlParameter("@media", "Movie"));

//    int affectedRows = cmd.ExecuteNonQuery();
//}
//catch (SqlException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    connection.Close();
//    Console.WriteLine("Connessione Chiusa");
//}




bool continua = true;
while (continua) {
    Console.WriteLine("0 per uscire / 1 - per aggiungere un nuovo prodotto / 2 - cerca prodotto per titolo");
    string choice = Console.ReadLine();
    switch (choice) {
        case "2":
            connection.Open();
            Console.WriteLine("Inserisci il titolo del prodotto");
            string search = Console.ReadLine();
            string searchQuery = "SELECT * FROM Products WHERE Title = @search ;";
            using (SqlCommand cmd = new SqlCommand(searchQuery, connection)) {
                cmd.Parameters.Add(new SqlParameter("@search", search.ToUpper()));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetInt32(0));
                        Console.WriteLine(reader.GetString(1));
                        Console.WriteLine(reader.GetString(2));
                    }
                }
            }
            connection.Close();
                break;
        case "1":
            Console.WriteLine("Inserisci codice seriale del prodotto");
            string codice = Console.ReadLine();
            Console.WriteLine("Inserisci titolo del prodotto");
            string titolo = Console.ReadLine();
            Console.WriteLine("Inserisci anno di distribuzione del prodotto (yyyy):");
            string anno = Console.ReadLine();
            Console.WriteLine("Inserisci titolo del prodotto: (Movie oppure Book)");
            string mediaType = Console.ReadLine();
            try
            {
                connection.Open();
                Console.WriteLine("Connessione Aperta");
                string query = "INSERT INTO Products (SerialCode,Title, Year, Media_type) VALUES (@codice_seriale , @titolo , @anno, @media)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@codice_seriale", codice));
                cmd.Parameters.Add(new SqlParameter("@titolo",titolo));
                cmd.Parameters.Add(new SqlParameter("@anno", anno));
                cmd.Parameters.Add(new SqlParameter("@media", mediaType));

                int affectedRows = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Connessione Chiusa");
            }

            break;
            case "0":
            continua = false;
            break;
            
    }

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
