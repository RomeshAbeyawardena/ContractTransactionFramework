using ContractTransactionFramework.Features.TransactionLedger;
using MediatR;

namespace ContractTransactionFramework.Core.Features.TransactionLedger;

public class PutHandler : IRequestHandler<Put, Models.TransactionLedger>
{
    public Task<Models.TransactionLedger> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
