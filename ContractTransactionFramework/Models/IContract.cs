namespace ContractTransactionFramework.Models;

public interface IContract
{
    Guid? TransactionId { get; set; }
    Guid? ContractId { get; set; }
    string? Name { get; set; }
    bool IsSuppressed { get; set; }
    DateTimeOffset Created { get; set; }
}
