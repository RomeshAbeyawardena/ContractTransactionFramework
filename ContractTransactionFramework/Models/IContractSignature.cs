namespace ContractTransactionFramework.Models;

public interface IContractSignature
{
    Guid ContractId { get; set; }
    Guid SignatureId { get; set; }
    bool IsSuppressed { get; set; }
    DateTimeOffset Created { get; set; }
}
