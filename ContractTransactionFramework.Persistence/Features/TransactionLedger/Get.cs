using ContractTransactionFramework.Features.TransactionLedger;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.TransactionLedger;

public record Get : IRequest<IEnumerable<Models.TransactionLedger>>, IQuery
{
}
