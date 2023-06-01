using ContractTransactionFramework.Models;

namespace ContractTransactionFramework.Persistence.Models;

public record Signature : ISignature
{
    public Guid SignatureKeyId { get; set; }
    public Guid IssuerKeyId { get; set; }
    public Guid IntentId { get; set; }
    public DateTimeOffset Created { get; set; }
}
