using ContractTransactionFramework.Features.Contract;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;

public record GetPaged : IRequest<IEnumerable<Models.TransactionLedgerHash>>, IQuery
{
}
