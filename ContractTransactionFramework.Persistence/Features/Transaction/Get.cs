using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Transaction;

public record Get : IRequest<IEnumerable<Models.Transaction>>, IQuery
{
}
