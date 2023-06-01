namespace ContractTransactionFramework.Models;

public interface IKey
{
    Guid IntentId { get; set; }
    string? Value { get; set; }
    string? KnownSecret { get; set; }
    bool IsSuppresed { get; set; }
    DateTimeOffset Created { get; set; }
}
