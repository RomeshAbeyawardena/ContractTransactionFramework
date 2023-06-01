using ContractTransactionFramework.Models;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.ContractSignature;

public record Post : IRequest<Models.ContractSignature>, IContractSignature
{
    public Guid ContractId { get; set; }
    public Guid SignatureId { get; set; }
    public bool IsSuppressed { get; set; }
    public DateTimeOffset Created { get; set; }
}
