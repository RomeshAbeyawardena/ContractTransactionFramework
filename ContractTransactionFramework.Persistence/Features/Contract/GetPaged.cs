using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Contract;

public record GetPaged : IRequest<IEnumerable<Models.Contract>>, IQuery
{
}
