using ContractTransactionFramework.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractTransactionFramework.Persistence.Models;

[Table(TABLE_NAME)]
public record Transaction : ITransaction
{
    public const string TABLE_NAME = nameof(Transaction);
    public Guid ContractId { get; set; }
    public string? Name { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
