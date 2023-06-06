using ContractTransactionFramework.Models;
using MediatR;
using RST.Contracts;

namespace ContractTransactionFramework.Persistence.Features.ContractSignature;

public record Put : IRequest<Models.ContractSignature>, IContractSignature, IDbCommand
{
    public Guid ContractId { get; set; }
    public Guid SignatureId { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
    public bool CommitChanges { get; set; }
}
