using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Intent;

public record GetPaged : IRequest<IEnumerable<Models.Intent>>, IQuery
{
}
