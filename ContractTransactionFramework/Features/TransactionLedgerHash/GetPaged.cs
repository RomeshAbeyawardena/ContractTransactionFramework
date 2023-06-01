using ContractTransactionFramework.Features.TransactionLedgerHash;
using MediatR;

namespace ContractTransactionFramework.Features.TransactionLedgerHash;

public record GetPaged : IRequest<IEnumerable<Models.TransactionLedgerHash>>, IQuery
{
}
