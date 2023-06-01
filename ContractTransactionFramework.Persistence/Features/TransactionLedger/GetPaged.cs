using ContractTransactionFramework.Features.TransactionLedger;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.TransactionLedger;

public record GetPaged : IRequest<IEnumerable<Models.TransactionLedger>>, IQuery
{
}
