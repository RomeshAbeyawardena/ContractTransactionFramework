using ContractTransactionFramework.Features.Signature;
using MediatR;

namespace ContractTransactionFramework.Features.Signature;

public record Get : IRequest<IEnumerable<Models.Signature>>, IQuery
{
}
