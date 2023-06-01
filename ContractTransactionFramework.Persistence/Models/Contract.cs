using ContractTransactionFramework.Models;

namespace ContractTransactionFramework.Persistence.Models;

public record Contract : IContract
{
    public Guid? TransactionId { get; set; }
    public Guid? ContractId { get; set; }
    public string? Name { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
