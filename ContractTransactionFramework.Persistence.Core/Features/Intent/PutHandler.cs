using ContractTransactionFramework.Persistence.Features.Intent;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Intent;

public class PutHandler : IRequestHandler<Put, Models.Intent>
{
    public Task<Models.Intent> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
