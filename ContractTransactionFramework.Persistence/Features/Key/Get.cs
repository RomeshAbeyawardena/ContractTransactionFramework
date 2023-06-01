using ContractTransactionFramework.Features.Key;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Key;

public record Get : IRequest<IEnumerable<Models.Key>>, IQuery
{
}
