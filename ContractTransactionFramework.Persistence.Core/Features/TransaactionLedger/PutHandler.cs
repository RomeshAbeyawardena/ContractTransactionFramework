using ContractTransactionFramework.Persistence.Features.TransactionLedger;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.TransactionLedger;

public class PutHandler : IRequestHandler<Put, Models.TransactionLedger>
{
    public Task<Models.TransactionLedger> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
