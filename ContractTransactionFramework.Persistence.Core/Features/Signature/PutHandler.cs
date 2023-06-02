using ContractTransactionFramework.Persistence.Features.Signature;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.Signature;

public class PutHandler : IRequestHandler<Put, Models.Signature>
{
    public Task<Models.Signature> Handle(Put request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
