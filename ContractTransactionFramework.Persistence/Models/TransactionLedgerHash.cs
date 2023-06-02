using ContractTransactionFramework.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractTransactionFramework.Persistence.Models;

[Table(TABLE_NAME)]
public record TransactionLedgerHash : ITransactionLedgerHash
{
    public const string TABLE_NAME = nameof(TransactionLedgerHash);
    public Guid TransactionLedgerId { get; set; }
    public string? DataHash { get; set; }
    public bool IsViable { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
