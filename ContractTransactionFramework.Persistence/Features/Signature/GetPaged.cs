using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Signature;

public record GetPaged : IRequest<IEnumerable<Models.Signature>>, IQuery
{
}
