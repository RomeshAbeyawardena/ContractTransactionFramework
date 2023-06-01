using ContractTransactionFramework.Features.Transaction;
using MediatR;

namespace ContractTransactionFramework.Features.Transaction;

public record Get : IRequest<IEnumerable<Models.Transaction>>, IQuery
{
}
