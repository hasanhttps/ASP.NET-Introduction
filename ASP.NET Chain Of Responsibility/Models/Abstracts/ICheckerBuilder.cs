using System;

namespace ASP.NET_Chain_Of_Responsibility.Models.Abstracts;

public interface ICheckerBuilder {

    // Properties

    public BaseChecker EmailChecker { get; set; }
    public BaseChecker PasswordChecker { get; set; }
    public BaseChecker UsernameChecker { get; set; }
}