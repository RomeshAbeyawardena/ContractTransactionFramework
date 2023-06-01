using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Transaction;

public record GetPaged : IRequest<IEnumerable<Models.Transaction>>, IQuery
{
}
