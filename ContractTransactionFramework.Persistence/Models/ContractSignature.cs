using ContractTransactionFramework.Models;

namespace ContractTransactionFramework.Persistence.Models;

public record ContractSignature : IContractSignature
{
    public Guid ContractId { get; set; }
    public Guid SignatureId { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
