using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Key;

public record GetPaged : IRequest<IEnumerable<Models.Key>>, IQuery
{
}
