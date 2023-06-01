using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Signature;

public record Post : IRequest<Models.Signature>, ISignature
{
    public Guid SignatureKeyId { get; set; }
    public Guid IssuerKeyId { get; set; }
    public Guid IntentId { get; set; }
    public DateTimeOffset Created { get; set; }
}
