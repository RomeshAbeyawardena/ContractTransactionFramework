using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Intent;

public record Get : IRequest<IEnumerable<Models.Intent>>, IQuery
{
}
