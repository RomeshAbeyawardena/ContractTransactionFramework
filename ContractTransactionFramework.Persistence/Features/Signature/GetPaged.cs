using ContractTransactionFramework.Features.Signature;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Signature;

public record GetPaged : IRequest<IEnumerable<Models.Signature>>, IQuery
{
}
