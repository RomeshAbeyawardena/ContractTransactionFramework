using ContractTransactionFramework.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractTransactionFramework.Persistence.Models;

[Table(TABLE_NAME)]
public record Key : IKey
{
    public const string TABLE_NAME = nameof(Key);
    public Guid IntentId { get; set; }
    public string? Value { get; set; }
    public string? KnownSecret { get; set; }
    public bool IsSuppresed { get; set; }
    public DateTimeOffset Created { get; set; }
}
