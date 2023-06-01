using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Signature;

public record Get : IRequest<IEnumerable<Models.Signature>>, IQuery
{
}
