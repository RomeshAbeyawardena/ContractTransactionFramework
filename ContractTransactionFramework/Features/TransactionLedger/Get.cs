using ContractTransactionFramework.Features.TransactionLedger;
using MediatR;

namespace ContractTransactionFramework.Features.TransactionLedger;

public record Get : IRequest<IEnumerable<Models.TransactionLedger>>, IQuery
{
}
