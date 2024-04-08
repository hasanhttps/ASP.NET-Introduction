using System;
using ASP.NET_Chain_Of_Responsibility.Models.Abstracts;
using ASP.NET_Chain_Of_Responsibility.Models.Concretes.Checkers;

namespace ASP.NET_Chain_Of_Responsibility.Models.Concretes;

public class CheckerDirector {

    // Properties

    public ICheckerBuilder? CheckerBuilder { get; set; }

    // Functions

    public void MakePersonCheck(Person person) {

        EmailChecker emailChecker = new EmailChecker();
        PasswordChecker passwordChecker = new PasswordChecker();
        UsernameChecker usernameChecker = new UsernameChecker();

        usernameChecker.Next = emailChecker;
        emailChecker.Next = passwordChecker;

        usernameChecker.Check(person);
    }
}