using ContractTransactionFramework.Features.Key;
using MediatR;

namespace ContractTransactionFramework.Core.Features.Key;

public class PutHandler : IRequestHandler<Put, Models.Key>
{
    public Task<Models.Key> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
