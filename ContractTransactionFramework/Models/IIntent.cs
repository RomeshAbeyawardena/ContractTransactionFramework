namespace ContractTransactionFramework.Models;

public interface IIntent
{
    string? Name { get; set; }
    string? Description { get; set; }
    bool IsSuppresed { get; set; }
    DateTimeOffset Created { get; set; }
}
