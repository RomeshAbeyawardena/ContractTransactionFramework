namespace ContractTransactionFramework.Models;

public interface ITransactionLedger
{
    Guid ParentTransactionLedgerId { get; set; }
    Guid? ContractId { get; set; }
    Guid TransactionId { get; set; }
    Guid SignatureId { get; set; }
    string? Data { get; set; }
    int Length { get; set; }
    bool IsValid { get; set; }
    DateTimeOffset CommitedDate { get; set; }
    bool IsSuppressed { get; set; }
    DateTimeOffset Created { get; set; }
}
