namespace ContractTransactionFramework.Models;

public interface ITransaction
{
    Guid ContractId { get; set; }
    string? Name { get; set; }
    bool IsSuppressed { get; set; }
    DateTimeOffset Created { get; set; }
}
