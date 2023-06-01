using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Features.Contract;

public record Get : IRequest<IEnumerable<Models.Contract>>, IQuery
{
}
