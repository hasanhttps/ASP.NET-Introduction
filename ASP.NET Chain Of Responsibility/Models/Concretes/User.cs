using System;
using ASP.NET_Chain_Of_Responsibility.Models.Abstracts;
namespace ASP.NET_Chain_Of_Responsibility.Models.Concretes;

public class User : Person {

    // Constructors

    public User(string usernname, string email, string password)
        : base(usernname, email, password) {

    }

    public User() { 
    
    }

}