namespace ContractTransactionFramework.Models;

public record Transaction : ITransaction
{
    public Guid ContractId { get; set; }
    public string? Name { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
