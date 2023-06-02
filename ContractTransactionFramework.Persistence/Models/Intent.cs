using ContractTransactionFramework.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractTransactionFramework.Persistence.Models;

[Table(TABLE_NAME)]
public record Intent : IIntent
{
    public const string TABLE_NAME = nameof(Intent);
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsSuppresed { get; set; }
    public DateTimeOffset Created { get; set; }
}
