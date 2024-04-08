using System;
using ASP.NET_Chain_Of_Responsibility.Models.Abstracts;

namespace ASP.NET_Chain_Of_Responsibility.Models.Concretes.Checkers;

public class UsernameChecker : BaseChecker {

    // Functions

    public override void Check(object? request){
        if (request is Person person) {
            if (!string.IsNullOrEmpty(person.Username) && person.Username.Length > 6) {
                Console.WriteLine("Username is correct ...");
                Next?.Check(request);
            }
            else {
                Console.WriteLine("Username is invalid!");
            }
        }
    }
}
