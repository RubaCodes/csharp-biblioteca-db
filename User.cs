public class User {
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public double PhoneNumber { get; set; }
    public bool Registrato { get; set; }
    //costruttore

    public User(string lastname, string firstname, string email, string password, double phoneNumber) {
        LastName = lastname;
        FirstName = firstname;  
        Email = email;  
        Password = password;
        PhoneNumber = phoneNumber;  
    }
}