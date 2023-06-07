using ContractTransactionFramework.Models;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Features.Signature;

public record Put : IRequest<Models.Signature>, ISignature, IDbCommand
{
    public Guid SignatureKeyId { get; set; }
    public Guid IssuerKeyId { get; set; }
    public Guid IntentId { get; set; }
    public DateTimeOffset Created { get; set; }
    public bool CommitChanges { get; set; }
}
