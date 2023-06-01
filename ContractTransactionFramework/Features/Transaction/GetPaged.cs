using ContractTransactionFramework.Features.Transaction;
using MediatR;

namespace ContractTransactionFramework.Features.Transaction;

public record GetPaged : IRequest<IEnumerable<Models.Transaction>>, IQuery
{
}
