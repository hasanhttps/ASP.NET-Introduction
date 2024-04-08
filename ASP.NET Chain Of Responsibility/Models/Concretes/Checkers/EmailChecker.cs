using ASP.NET_Chain_Of_Responsibility.Models.Abstracts;
using System;

namespace ASP.NET_Chain_Of_Responsibility.Models.Concretes.Checkers;

public class EmailChecker : BaseChecker {

    // Functions

    public override void Check(object? request) {
        if (request is Person person) {
            if (!string.IsNullOrEmpty(person.Email) && person.Email.Contains("@")) {
                Console.WriteLine("Email is correct ...");
                Next?.Check(request);
            }
            else {
                Console.WriteLine("Email is invalid!");
            }
        }
    }
}
