using System;

namespace ASP.NET_Chain_Of_Responsibility.Models.Abstracts;

public abstract class Person {

    // Properties

    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    // Constructors

    public Person(string username, string password, string email) {
        Username = username;
        Password = password;
        Email = email;
    }

    public Person() { 
    
    }
}