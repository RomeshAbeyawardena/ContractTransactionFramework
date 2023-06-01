using ContractTransactionFramework.Features.Key;
using MediatR;

namespace ContractTransactionFramework.Features.Key;

public record Get : IRequest<IEnumerable<Models.Key>>, IQuery
{
}
