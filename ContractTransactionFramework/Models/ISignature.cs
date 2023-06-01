namespace ContractTransactionFramework.Models;

public interface ISignature
{
    Guid SignatureKeyId { get; set; }
    Guid IssuerKeyId { get; set; }
    Guid IntentId { get; set; }
    DateTimeOffset Created { get; set; }
}
