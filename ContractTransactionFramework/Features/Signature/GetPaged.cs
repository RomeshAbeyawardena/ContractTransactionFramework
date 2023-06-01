using ContractTransactionFramework.Features.Signature;
using MediatR;

namespace ContractTransactionFramework.Features.Signature;

public record GetPaged : IRequest<IEnumerable<Models.Signature>>, IQuery
{
}
