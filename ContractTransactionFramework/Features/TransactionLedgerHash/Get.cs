using ContractTransactionFramework.Features.TransactionLedgerHash;
using MediatR;

namespace ContractTransactionFramework.Features.TransactionLedgerHash;

public record Get : IRequest<IEnumerable<Models.TransactionLedgerHash>>, IQuery
{
}
