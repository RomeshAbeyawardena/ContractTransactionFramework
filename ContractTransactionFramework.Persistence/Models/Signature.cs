using ContractTransactionFramework.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractTransactionFramework.Persistence.Models;

[Table(TABLE_NAME)]
public record Signature : ISignature
{
    public const string TABLE_NAME = nameof(Signature);
    public Guid SignatureKeyId { get; set; }
    public Guid IssuerKeyId { get; set; }
    public Guid IntentId { get; set; }
    public DateTimeOffset Created { get; set; }
}
