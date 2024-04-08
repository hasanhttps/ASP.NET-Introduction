using System;
using ASP.NET_Chain_Of_Responsibility.Models.Abstracts;

namespace ASP.NET_Chain_Of_Responsibility.Models.Concretes.Checkers;

public class PasswordChecker : BaseChecker {

    // Functions

    public override void Check(object? request){
        if (request is Person person) {
            if (!string.IsNullOrEmpty(person.Password) && person.Password.Length >= 8) {
                Console.WriteLine("Password is correct ...");
                Next?.Check(request);
            }
            else {
                Console.WriteLine("Password is invalid!");
            }
        }
    }
}
