using ContractTransactionFramework.Features.Transaction;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Transaction;

public class PutHandler : IRequestHandler<Put, Models.Transaction>
{
    public Task<Models.Transaction> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
