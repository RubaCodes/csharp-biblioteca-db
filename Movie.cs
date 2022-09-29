// See https://aka.ms/new-console-template for more information
public class Movie : Product {
    public Movie(string serialcode, string titolo) : base(serialcode, titolo)
    {
        SerialCode = serialcode;
        Title = titolo;
    }
    public string FullAuthorName
    {
        get { return AuthorFirstName + " " + AuthorLastName; }
    }
    public int Durata { get; set; }
}