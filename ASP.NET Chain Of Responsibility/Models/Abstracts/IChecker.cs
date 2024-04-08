using System;

namespace ASP.NET_Chain_Of_Responsibility.Models.Abstracts;

public interface IChecker {

    // Properties

    public IChecker? Next { get; set; }

    // Prototypes

    public void Check(object? request);
}