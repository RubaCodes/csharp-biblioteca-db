// See https://aka.ms/new-console-template for more information
public class Product {
    public string SerialCode { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public string Category { get; set; }
    public int Shelf { get; set; }
    public string AuthorFirstName { get; set; }
    public string AuthorLastName {get; set; }
    public bool Status { get; set; }

    public Product(string serialcode, string title) {
        SerialCode = serialcode;
        Title = title;  
    }
}
