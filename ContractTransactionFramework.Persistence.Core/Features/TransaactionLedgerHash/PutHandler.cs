using ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedgerHash;

public class PutHandler : IRequestHandler<Put, Models.TransactionLedgerHash>
{
    public Task<Models.TransactionLedgerHash> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
