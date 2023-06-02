using ContractTransactionFramework.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractTransactionFramework.Persistence.Models;

[Table(TABLE_NAME)]
public record TransactionLedger : ITransactionLedger
{
    public const string TABLE_NAME = nameof(TransactionLedger);
    public Guid ParentTransactionLedgerId { get; set; }
    public Guid? ContractId { get; set; }
    public Guid TransactionId { get; set; }
    public Guid SignatureId { get; set; }
    public string? Data { get; set; }
    public int Length { get; set; }
    public bool IsValid { get; set; }
    public DateTimeOffset CommitedDate { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
