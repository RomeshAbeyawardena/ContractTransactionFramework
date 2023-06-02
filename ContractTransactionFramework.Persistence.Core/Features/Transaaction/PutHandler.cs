using ContractTransactionFramework.Persistence.Features.Transaction;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Transaction;

public class PutHandler : IRequestHandler<Put, Models.Transaction>
{
    public Task<Models.Transaction> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
