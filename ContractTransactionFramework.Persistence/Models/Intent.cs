using ContractTransactionFramework.Models;

namespace ContractTransactionFramework.Persistence.Models;

public record Intent : IIntent
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsSuppresed { get; set; }
    public DateTimeOffset Created { get; set; }
}
