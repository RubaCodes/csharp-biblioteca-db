
public class Book : Product {
    public Book(string serialcode, string titolo) : base(serialcode, titolo) {
        SerialCode = serialcode;
        Title = titolo;
    }
public int Pagine { get; set; }
public string FullAuthorName
    {
        get { return AuthorFirstName + " " + AuthorLastName; }
    }
}
