using System;

namespace ASP.NET_Chain_Of_Responsibility.Models.Abstracts;

public abstract class BaseChecker : IChecker {

    public IChecker? Next { get; set; }
    public abstract void Check(object? request);
}