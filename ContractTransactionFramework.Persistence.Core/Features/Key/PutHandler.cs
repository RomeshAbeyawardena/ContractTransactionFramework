using ContractTransactionFramework.Persistence.Features.Key;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Key;

public class PutHandler : IRequestHandler<Put, Models.Key>
{
    public Task<Models.Key> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
