namespace ContractTransactionFramework.Models;

public interface ITransactionLedgerHash
{
    Guid TransactionLedgerId { get; set; }
    string? DataHash { get; set; }
    bool IsViable { get; set; }
    bool IsSuppressed { get; set; }
    DateTimeOffset Created { get; set; }
}
