using ContractTransactionFramework.Features.Signature;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Signature;

public record Get : IRequest<IEnumerable<Models.Signature>>, IQuery
{
}
