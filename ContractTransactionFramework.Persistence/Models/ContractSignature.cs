using ContractTransactionFramework.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractTransactionFramework.Persistence.Models;

[Table(TABLE_NAME)]
public record ContractSignature : IContractSignature
{
    public const string TABLE_NAME = nameof(ContractSignature);
    public Guid ContractId { get; set; }
    public Guid SignatureId { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
